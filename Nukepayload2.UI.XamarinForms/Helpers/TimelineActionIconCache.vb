Public Class TimelineActionIconCache
    Private Shared s_icons As New Dictionary(Of TimelineActionIcons, ImageSource)
    Public Shared Function GetIcon(icon As TimelineActionIcons) As ImageSource
        Dim img As ImageSource = Nothing
        If s_icons.TryGetValue(icon, img) Then
            Return img
        End If
        img = ImageSource.FromStream(Function()
                                         Dim resName As String = $"{icon.ToString}.png"
                                         Dim res = My.EmbeddedResources.Assets(resName)
                                         If res Is Nothing Then
                                             Throw New ArgumentException("Icon was not found.", NameOf(icon))
                                         End If
                                         Return res
                                     End Function)
        s_icons.Add(icon, img)
        Return img
    End Function
End Class
