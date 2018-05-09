Public Class ContentControl
    Inherits ContentView

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
                           GetType(Object), GetType(ContentControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ContentControl)
                                                Dim old = oldValue
                                                Dim newVal = newValue
                                                If old IsNot newVal Then
                                                    If this.Content Is Nothing Then
                                                        this.UpdateContent()
                                                    End If
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
                           GetType(DataTemplate), GetType(ContentControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ContentControl)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.UpdateContent()
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
                           GetType(DataTemplateSelector), GetType(ContentControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ContentControl)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.UpdateContent()
                                                End If
                                            End Sub)

    Public Property Tag As Object
        Get
            Return GetValue(TagProperty)
        End Get
        Set
            SetValue(TagProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly TagProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Tag),
                           GetType(Object), GetType(ContentControl),
                           Nothing)

    Protected Friend Sub UpdateContent()
        ' 时间线编辑时出现诡异的 NullReference。需要进一步跟踪。
        Content = CView(InnerContent, Me, ContentTemplate, ContentTemplateSelector)
    End Sub

End Class
