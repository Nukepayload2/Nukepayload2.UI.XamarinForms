Imports Nukepayload2.UI.Xaml.Views

Public Class ChatHtmlContent
    Inherits ChatItemBase

    Public Property ImageUri As Uri
    Public Property Title As String
    Public Property NavigateUri As Uri

    Public ReadOnly Property NavigateCommand As New Command(
        Async Sub()
            Dim vm = ViewModels.EmbeddedWebViewModel.Instance
            vm.Title = Title
            vm.NavigateUri = NavigateUri
            Await Services.NavigationService.NavigateToAsync(Of EmbeddedWebViewPage)()
        End Sub)

    Public Overrides Function ToBriefString() As String
        Return Title
    End Function
End Class
