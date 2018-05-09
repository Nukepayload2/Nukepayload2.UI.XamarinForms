Public Class HyperlinkButton
    Inherits ContentView

    Public Property Text As String
        Get
            Return GetValue(TextProperty)
        End Get
        Set
            SetValue(TextProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly TextProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Text),
                           GetType(String), GetType(HyperlinkButton),
                           String.Empty)

    Public Property NavigateUri As Uri
        Get
            Return GetValue(NavigateUriProperty)
        End Get
        Set
            SetValue(NavigateUriProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly NavigateUriProperty As BindableProperty =
                           BindableProperty.Create(NameOf(NavigateUri),
                           GetType(Uri), GetType(HyperlinkButton),
                           Nothing)

    Private Sub TblLink_Click(sender As Object, e As EventArgs) Handles TblLinkWithEvents.Tapped
        Dim uri = NavigateUri
        If uri IsNot Nothing Then
            Device.OpenUri(uri)
        End If
    End Sub

    Private Sub OnComponentInitialized()
        Content.BindingContext = Me
    End Sub
End Class
