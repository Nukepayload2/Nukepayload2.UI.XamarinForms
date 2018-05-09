Imports System.ComponentModel

Public Class UndoStorage(Of T As {Class, ICloneable(Of T)})
    Implements INotifyPropertyChanged

    Private _undoStorage As New LinkedList(Of T)
    Private _redoStorage As New Stack(Of T)
    Private _delay As TimeSpan
    Private WithEvents DelayTimer As New DispatcherTimer With {.IsEnabled = False}

    Public Sub New()
        MyClass.New(100, TimeSpan.FromMilliseconds(500))
    End Sub

    Public Sub New(capacity As Integer, delay As TimeSpan)
        If capacity < 3 Then
            Throw New ArgumentOutOfRangeException(NameOf(capacity))
        End If
        Me.Capacity = capacity
        DelayTimer.Interval = delay
        _delay = delay
    End Sub

    Public ReadOnly Property Capacity As Integer

    Public ReadOnly Property CanUndo As Boolean
        Get
            Return _undoStorage.Count > 1
        End Get
    End Property

    Public ReadOnly Property CanRedo As Boolean
        Get
            Return _redoStorage.Count > 0
        End Get
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub SaveDelay(value As T)
        _delayTimeTickArgs = value
        DelayTimer.Stop()
        DelayTimer.Interval = _delay
        DelayTimer.Start()
    End Sub

    Public Sub Save(value As T)
        _redoStorage.Clear()
        _undoStorage.AddLast(value.Clone)
        If _undoStorage.Count > Capacity Then
            _undoStorage.RemoveFirst()
        End If

        NotifyPropChanged()
    End Sub

    Private _delayTimeTickArgs As T
    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs) Handles DelayTimer.Tick
        DelayTimer.Stop()
        Save(_delayTimeTickArgs)
    End Sub

    Private Sub NotifyPropChanged()
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CanUndo)))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CanRedo)))
    End Sub

    Public Function Undo() As T
        If _undoStorage.Count > 0 Then
            Dim removed = _undoStorage.Last
            _redoStorage.Push(removed.Value)
            _undoStorage.RemoveLast()
        End If
        If _undoStorage.Count = 0 Then
            Return Nothing
        End If
        Dim last = _undoStorage.Last
        NotifyPropChanged()
        Return last.Value
    End Function

    Public Function Redo() As T
        If _redoStorage.Count = 0 Then
            Return Nothing
        End If
        Dim value = _redoStorage.Pop
        _undoStorage.AddLast(value)
        NotifyPropChanged()
        Return value
    End Function

    Public Sub Clear()
        _undoStorage.Clear()
        _redoStorage.Clear()
    End Sub
End Class
