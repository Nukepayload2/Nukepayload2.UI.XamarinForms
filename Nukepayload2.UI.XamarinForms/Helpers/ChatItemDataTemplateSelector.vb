Public Class ChatItemDataTemplateSelector
    Inherits DataTemplateSelector

    Protected Overrides Function OnSelectTemplate(item As Object, container As BindableObject) As DataTemplate
        Dim model = TryCast(item, ChatItemBase)
        If model Is Nothing Then
            Return Nothing
        End If
        Return If(model.Placement = ChatItemPlacement.Left,
            TemplateManager.ChatViewTemples.ListViewChatItemLeftDataTemplate,
            TemplateManager.ChatViewTemples.ListViewChatItemRightDataTemplate)
    End Function
End Class
