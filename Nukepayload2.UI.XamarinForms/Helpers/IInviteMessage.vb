Imports System.Windows.Input

Public Interface IInviteMessage
    ReadOnly Property Accept As ICommand
    ReadOnly Property Decline As ICommand
    ReadOnly Property Text As String
End Interface
