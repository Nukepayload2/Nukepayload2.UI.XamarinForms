Public Class ChatText
    Inherits ChatItemBase

    Public Property Text As String

    Public Overrides Function ToBriefString() As String
        Return Text
    End Function
End Class
