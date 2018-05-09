Public Class ChatHyperlink
    Inherits ChatItemBase

    Public Property NavigateUri As Uri
    Public Property Text As String

    Public Overrides Function ToBriefString() As String
        Return Text
    End Function
End Class
