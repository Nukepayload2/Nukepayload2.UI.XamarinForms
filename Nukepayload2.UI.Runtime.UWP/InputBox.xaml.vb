Public NotInheritable Class InputBox
    Inherits ContentDialog

    Private _returnDefaultValue As Boolean

    Public Overloads Async Function ShowAsync(Prompt As String, Title As String, defaultValue As String) As Task(Of String)
        Me.Title = Title
        TxtPrompt.Text = Prompt
        TxtOutput.Text = If(defaultValue, String.Empty)
        Await ShowAsync()
        Return If(_returnDefaultValue, defaultValue, TxtOutput.Text)
    End Function

    Private Sub BtnOk_Click(sender As Object, e As RoutedEventArgs)
        _returnDefaultValue = False
        Hide()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As RoutedEventArgs)
        Hide()
    End Sub
End Class