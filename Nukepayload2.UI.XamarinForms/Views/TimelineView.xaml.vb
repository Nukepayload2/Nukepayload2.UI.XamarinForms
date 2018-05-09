Public Class TimelineView
    Inherits ContentView

    Public Property Header As String
        Get
            Return GetValue(HeaderProperty)
        End Get
        Set
            SetValue(HeaderProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly HeaderProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Header),
                           GetType(String), GetType(TimelineView),
                           String.Empty)

    Public Property ItemsSource As IEnumerable
        Get
            Return GetValue(ItemsSourceProperty)
        End Get
        Set
            SetValue(ItemsSourceProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ItemsSourceProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemsSource),
                           GetType(IEnumerable), GetType(TimelineView),
                           Nothing)

    Public Property ItemTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(ItemTemplateSelectorProperty)
        End Get
        Set
            SetValue(ItemTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ItemTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemTemplateSelector),
                           GetType(DataTemplateSelector), GetType(TimelineView),
                           New TimelineViewDataTemplateSelector)

    Private Sub OnComponentInitialized()
        Content.BindingContext = Me
    End Sub
End Class
