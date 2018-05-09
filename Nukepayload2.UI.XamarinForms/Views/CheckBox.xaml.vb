Public Class CheckBox
    Inherits ContentView

    Public Property IsChecked As Boolean
        Get
            Return GetValue(IsCheckedProperty)
        End Get
        Set
            SetValue(IsCheckedProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsCheckedProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsChecked),
                           GetType(Boolean), GetType(CheckBox),
                           False, defaultBindingMode:=BindingMode.TwoWay,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, CheckBox)
                                                Dim old = DirectCast(oldValue, Boolean)
                                                Dim newVal = DirectCast(newValue, Boolean)
                                                If old <> newVal Then
                                                    this.CtlBlackRectangle.IsVisible = old
                                                    this.CtlWhiteRectangle.IsVisible = old
                                                    this.CtlBlueRectangle.IsVisible = newVal
                                                    this.LblChecked.IsVisible = newVal
                                                End If
                                            End Sub)

    Public Property InnerContent As Object
        Get
            Return GetValue(InnerContentProperty)
        End Get
        Set
            SetValue(InnerContentProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly InnerContentProperty As BindableProperty =
                           BindableProperty.Create(NameOf(InnerContent),
                           GetType(Object), GetType(CheckBox),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, CheckBox)
                                                If oldValue IsNot newValue Then
                                                    this.CtlContent.InnerContent = newValue
                                                End If
                                            End Sub)

    Public Property ContentTemplate As DataTemplate
        Get
            Return GetValue(ContentTemplateProperty)
        End Get
        Set
            SetValue(ContentTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ContentTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ContentTemplate),
                           GetType(DataTemplate), GetType(CheckBox),
                           TemplateManager.DefaultContentTemplates.CheckBoxDefaultContentTemplate,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, CheckBox)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.CtlContent.ContentTemplate = newVal
                                                End If
                                            End Sub)

    Public Property ContentTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(ContentTemplateSelectorProperty)
        End Get
        Set
            SetValue(ContentTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ContentTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ContentTemplateSelector),
                           GetType(DataTemplateSelector), GetType(CheckBox),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, CheckBox)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.CtlContent.ContentTemplateSelector = newVal
                                                End If
                                            End Sub)

    Private Sub OnComponentInitialized()
        CtlContent.ContentTemplate = ContentTemplate
    End Sub

    Private Sub CheckBoxInteractiveAreaWithEvents_Tapped(sender As Object, e As EventArgs) Handles CheckBoxInteractiveAreaWithEvents.Tapped
        IsChecked = Not IsChecked
        If IsChecked Then
            RaiseEvent Checked(Me, EventArgs.Empty)
        Else
            RaiseEvent Unchecked(Me, EventArgs.Empty)
        End If
    End Sub

    Public Event Checked As EventHandler
    Public Event Unchecked As EventHandler

End Class
