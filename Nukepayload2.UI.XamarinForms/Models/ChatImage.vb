Imports System.IO

Public Class ChatImage
    Inherits ChatItemBase

    Public Property SourceUri As Uri

    Public Overrides Function ToBriefString() As String
        Return "[图片]"
    End Function
End Class
