Imports System.Windows.Input

Public Class EditorControl
    Inherits ContentView

    Public Property IsEditing As Boolean
        Get
            Return GetValue(IsEditingProperty)
        End Get
        Set
            SetValue(IsEditingProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsEditingProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsEditing),
                           GetType(Boolean), GetType(EditorControl),
                           False, BindingMode.TwoWay,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, Boolean)
                                                Dim newVal = DirectCast(newValue, Boolean)
                                                If old <> newVal Then
                                                    this.ViewPart.IsVisible = old
                                                    this.EditToggleButton.IsVisible = old
                                                    this.EditPart.IsVisible = newVal
                                                    this.SaveToggleButton.IsVisible = newVal
                                                End If
                                            End Sub)

    Public Property EditCommand As ICommand
        Get
            Return GetValue(EditCommandProperty)
        End Get
        Set
            SetValue(EditCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly EditCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(EditCommand),
                           GetType(ICommand), GetType(EditorControl),
                           defaultValueCreator:=Function(obj) New EditorControlDefaultEditCommand(obj),
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.EditToggleButton.Command = newVal
                                                End If
                                            End Sub)

    Public Property EditCommandParameter As Object
        Get
            Return GetValue(EditCommandParameterProperty)
        End Get
        Set
            SetValue(EditCommandParameterProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly EditCommandParameterProperty As BindableProperty =
                           BindableProperty.Create(NameOf(EditCommandParameter),
                           GetType(Object), GetType(EditorControl),
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                If oldValue IsNot newValue Then
                                                    this.EditToggleButton.CommandParameter = newValue
                                                End If
                                            End Sub)

    Public Property SaveCommand As ICommand
        Get
            Return GetValue(SaveCommandProperty)
        End Get
        Set
            SetValue(SaveCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly SaveCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(SaveCommand),
                           GetType(ICommand), GetType(EditorControl),
                           defaultValueCreator:=Function(obj) New EditorControlDefaultSaveCommand(obj),
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.SaveToggleButton.Command = newVal
                                                End If
                                            End Sub)

    Public Property SaveCommandParameter As Object
        Get
            Return GetValue(SaveCommandParameterProperty)
        End Get
        Set
            SetValue(SaveCommandParameterProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly SaveCommandParameterProperty As BindableProperty =
                           BindableProperty.Create(NameOf(SaveCommandParameter),
                           GetType(Object), GetType(EditorControl),
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                If oldValue IsNot newValue Then
                                                    this.SaveToggleButton.CommandParameter = newValue
                                                End If
                                            End Sub)

    Public Property IsSaving As Boolean
        Get
            Return GetValue(IsSavingProperty)
        End Get
        Set
            SetValue(IsSavingProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsSavingProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsSaving),
                           GetType(Boolean), GetType(EditorControl),
                           False, BindingMode.TwoWay,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, Boolean)
                                                Dim newVal = DirectCast(newValue, Boolean)
                                                If old <> newVal Then
                                                    this.SaveToggleButton.IsEnabled = old
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
                           GetType(Object), GetType(EditorControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                If oldValue IsNot newValue Then
                                                    this.ViewPart.InnerContent = newValue
                                                    this.EditPart.InnerContent = newValue
                                                End If
                                            End Sub)

    Public Property ViewContentTemplate As DataTemplate
        Get
            Return GetValue(ViewContentTemplateProperty)
        End Get
        Set
            SetValue(ViewContentTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ViewContentTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ViewContentTemplate),
                           GetType(DataTemplate), GetType(EditorControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.ViewPart.ContentTemplate = newVal
                                                End If
                                            End Sub)

    Public Property ViewContentTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(ViewContentTemplateSelectorProperty)
        End Get
        Set
            SetValue(ViewContentTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ViewContentTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ViewContentTemplateSelector),
                           GetType(DataTemplateSelector), GetType(EditorControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.ViewPart.ContentTemplateSelector = newVal
                                                End If
                                            End Sub)

    Public Property EditContentTemplate As DataTemplate
        Get
            Return GetValue(EditContentTemplateProperty)
        End Get
        Set
            SetValue(EditContentTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly EditContentTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(EditContentTemplate),
                           GetType(DataTemplate), GetType(EditorControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.EditPart.ContentTemplate = newVal
                                                End If
                                            End Sub)

    Public Property EditContentTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(EditContentTemplateSelectorProperty)
        End Get
        Set
            SetValue(EditContentTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly EditContentTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(EditContentTemplateSelector),
                           GetType(DataTemplateSelector), GetType(EditorControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditorControl)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.EditPart.ContentTemplateSelector = newVal
                                                End If
                                            End Sub)

    Protected Friend ReadOnly Property ClickHandlersCount As Integer

    Public Custom Event Click As EventHandler
        AddHandler(value As EventHandler)
            AddHandler EditToggleButton.Clicked, value
            AddHandler SaveToggleButton.Clicked, value
            _ClickHandlersCount += 1
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler EditToggleButton.Clicked, value
            RemoveHandler SaveToggleButton.Clicked, value
            _ClickHandlersCount -= 1
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Private Sub OnComponentInitialized()
        EditToggleButton.Command = EditCommand
        SaveToggleButton.Command = SaveCommand
    End Sub
End Class
