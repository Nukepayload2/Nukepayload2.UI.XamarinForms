Imports System.ComponentModel
Imports Nukepayload2.UI.Xaml.ViewModels

Namespace Views

    Public Class EmbeddedWebViewPage
        Inherits ContentPage

        Private WithEvents ViewModel As EmbeddedWebViewModel

        Private Sub OnComponentInitialized()
            ViewModel = EmbeddedWebViewModel.Instance
            BindingContext = ViewModel
            Title = ViewModel.Title
            WebBrowser.Source = ViewModel.NavigateUri
        End Sub

        Private Sub ViewModel_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles ViewModel.PropertyChanged
            Select Case e.PropertyName
                Case NameOf(ViewModel.Title)
                    Title = If(ViewModel.Title, String.Empty)
                Case NameOf(ViewModel.NavigateUri)
                    WebBrowser.Source = ViewModel.NavigateUri
                Case NameOf(ViewModel.Cookies)
                    If ViewModel.Cookies <> Nothing Then
                        WebBrowser.Eval($"document.cookie = '{ViewModel.Cookies}'")
                    End If
            End Select
        End Sub
    End Class

End Namespace