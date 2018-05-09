Public Class ChatItemContentTemplateSelector
    Inherits DataTemplateSelector

    Protected Overrides Function OnSelectTemplate(item As Object, container As BindableObject) As DataTemplate
        Dim model = TryCast(item, ChatItemBase)
        If model Is Nothing Then
            Return Nothing
        End If
        If TypeOf model Is ChatText Then
            Return TemplateManager.ChatViewTemples.TextMessageTemplate
        ElseIf TypeOf model Is ChatHtmlContent Then
            Return TemplateManager.ChatViewTemples.HtmlContentMessageTemplate
        ElseIf TypeOf model Is ChatInvite Then
            Return TemplateManager.ChatViewTemples.InviteMessageTemplate
        ElseIf TypeOf model Is ChatHyperlink Then
            Return TemplateManager.ChatViewTemples.HyperlinkMessageTemplate
        ElseIf TypeOf model Is ChatImage Then
            Return TemplateManager.ChatViewTemples.ImageMessageTemplate
        End If
        Return Nothing
    End Function
End Class
