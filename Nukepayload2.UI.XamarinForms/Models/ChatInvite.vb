Imports System.Windows.Input

Public Class ChatInvite
    Inherits ChatItemBase

    Public Property Text As String
    Public Property TargetConferenceId As Integer
    Public Property Accept As ICommand
    Public Property Decline As ICommand
    Public Overrides Function ToBriefString() As String
        Return Text
    End Function
End Class
