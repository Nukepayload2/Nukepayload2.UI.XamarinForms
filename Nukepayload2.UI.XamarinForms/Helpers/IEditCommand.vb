Imports System.Windows.Input

Public Interface IEditCommand
    ReadOnly Property Text As String
    ReadOnly Property Symbol As Object
    ReadOnly Property Command As ICommand
End Interface
