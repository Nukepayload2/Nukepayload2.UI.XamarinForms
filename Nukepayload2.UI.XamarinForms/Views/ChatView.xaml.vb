Imports System.Windows.Input

Public Class ChatView
    Inherits ContentView

    Public Property MessageItemsSource As IEnumerable
        Get
            Return GetValue(MessageItemsSourceProperty)
        End Get
        Set
            SetValue(MessageItemsSourceProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly MessageItemsSourceProperty As BindableProperty =
                           BindableProperty.Create(NameOf(MessageItemsSource),
                           GetType(IEnumerable), GetType(ChatView),
                           Nothing)

    Public Property MessageItemTemplate As DataTemplate
        Get
            Return GetValue(MessageItemTemplateProperty)
        End Get
        Set
            SetValue(MessageItemTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly MessageItemTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(MessageItemTemplate),
                           GetType(DataTemplate), GetType(ChatView),
                           TemplateManager.ChatViewTemples.MessageGroupByDateDataTemplate)

    Public Property CommentEditCommands As IEnumerable(Of IEditCommand)
        Get
            Return GetValue(CommentEditCommandsProperty)
        End Get
        Set
            SetValue(CommentEditCommandsProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly CommentEditCommandsProperty As BindableProperty =
                           BindableProperty.Create(NameOf(CommentEditCommands),
                           GetType(IEnumerable(Of IEditCommand)), GetType(ChatView),
                           Nothing)

    Public Property CommentEditItemTemplate As DataTemplate
        Get
            Return GetValue(CommentEditItemTemplateProperty)
        End Get
        Set
            SetValue(CommentEditItemTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly CommentEditItemTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(CommentEditItemTemplate),
                           GetType(DataTemplate), GetType(ChatView),
                           TemplateManager.ChatViewTemples.ChatButtonDataTemplate)

    Public Property Document As String
        Get
            Return GetValue(DocumentProperty)
        End Get
        Set
            SetValue(DocumentProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly DocumentProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Document),
                           GetType(String), GetType(ChatView),
                           String.Empty)

    Public Property SendCommand As ICommand
        Get
            Return GetValue(SendCommandProperty)
        End Get
        Set
            SetValue(SendCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly SendCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(SendCommand),
                           GetType(ICommand), GetType(ChatView),
                           Nothing)

    Private Sub OnComponentInitialized()
        Content.BindingContext = Me
    End Sub
End Class
