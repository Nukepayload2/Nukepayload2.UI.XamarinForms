Imports System.Windows.Input

Friend Class RelayCommand
    Implements ICommand

    Public Sub New(onExecute As Action(Of RelayCommand, Object), Optional onCanExecute As Func(Of RelayCommand, Object, Boolean) = Nothing)
        Me.OnExecute = onExecute
        Me.OnCanExecute = onCanExecute
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Property OnExecute As Action(Of RelayCommand, Object)
    Public Property OnCanExecute As Func(Of RelayCommand, Object, Boolean)

    Private _IsEnabled As Boolean = True
    Public Property IsEnabled As Boolean
        Get
            Return _IsEnabled
        End Get
        Set(value As Boolean)
            Dim raise = _IsEnabled <> value
            _IsEnabled = value
            If raise Then
                RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        OnExecute?.Invoke(Me, parameter)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        If OnCanExecute Is Nothing Then
            Return IsEnabled
        End If
        Return OnCanExecute.Invoke(Me, parameter)
    End Function
End Class
