Imports System.Windows.Input

Public Class EditorControlDefaultEditCommand
    Implements ICommand

    Private obj As EditorControl

    Public Sub New(obj As EditorControl)
        Me.obj = obj
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If obj.ClickHandlersCount = 0 Then
            obj.IsEditing = True
        End If
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class

Public Class EditorControlDefaultSaveCommand
    Implements ICommand

    Private obj As EditorControl

    Public Sub New(obj As EditorControl)
        Me.obj = obj
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If obj.ClickHandlersCount = 0 Then
            obj.IsEditing = False
        End If
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
