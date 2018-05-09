Imports System.Collections.ObjectModel
Imports System.Collections.Specialized

Public Class ObservableGrouping(Of TKey, TValue)
    Implements IGrouping(Of TKey, TValue), INotifyCollectionChanged

    Public Sub New(key As TKey, values As IEnumerable(Of TValue))
        If values Is Nothing Then
            Me.Values = New ObservableCollection(Of TValue)
        Else
            Me.Values = New ObservableCollection(Of TValue)(values)
        End If
        Me.Key = key
    End Sub

    Public ReadOnly Property Values As ObservableCollection(Of TValue)

    Public Property Key As TKey Implements IGrouping(Of TKey, TValue).Key

    Public Custom Event CollectionChanged As NotifyCollectionChangedEventHandler Implements INotifyCollectionChanged.CollectionChanged
        AddHandler(value As NotifyCollectionChangedEventHandler)
            AddHandler DirectCast(Values, INotifyCollectionChanged).CollectionChanged, value
        End AddHandler
        RemoveHandler(value As NotifyCollectionChangedEventHandler)
            RemoveHandler DirectCast(Values, INotifyCollectionChanged).CollectionChanged, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As NotifyCollectionChangedEventArgs)
        End RaiseEvent
    End Event

    Public Function GetEnumerator() As IEnumerator(Of TValue) Implements IEnumerable(Of TValue).GetEnumerator
        Return Values.GetEnumerator
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function
End Class
