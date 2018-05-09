Public Class TimelineEditDataTemplateSelector
    Inherits DataTemplateSelector

    Protected Overrides Function OnSelectTemplate(item As Object, container As BindableObject) As DataTemplate
        If item Is Nothing Then
            Return Nothing
        End If
        With TemplateManager.TimelineTemplates
            If TypeOf item Is TimelineAction Then
                Return .TimelineActionEditDataTemplate
            ElseIf TypeOf item Is TimelineDate Then
                Return .TimelineDateEditDataTemplate
            ElseIf TypeOf item Is TimelineTime Then
                Return .TimelineTimeEditDataTemplate
            End If
        End With
        Return Nothing
    End Function
End Class
