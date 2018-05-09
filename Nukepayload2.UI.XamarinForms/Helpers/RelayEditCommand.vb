Imports System.Windows.Input

Public Class RelayEditCommand
    Implements IEditCommand

    Public Sub New(text As String, symbol As Object, command As ICommand)
        Me.Text = text
        Me.Symbol = symbol
        Me.Command = command
    End Sub

    Public Property Text As String Implements IEditCommand.Text

    Public Property Symbol As Object Implements IEditCommand.Symbol

    Public Property Command As ICommand Implements IEditCommand.Command

End Class
