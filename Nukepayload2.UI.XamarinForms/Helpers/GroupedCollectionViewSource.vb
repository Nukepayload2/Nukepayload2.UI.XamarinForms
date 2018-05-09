Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.ComponentModel

''' <summary>
''' 为指定的可观察集合创建一个经过分组的视图。
''' </summary>
Public Class GroupedCollectionViewSource(Of TKey, TValue As IKeyIndexable(Of TKey), TSource As {ICollection(Of TValue), INotifyCollectionChanged})
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private ReadOnly _groups As New List(Of ObservableGrouping(Of TKey, TValue))
    Private _groupHandlerRegistered As Boolean

    Private _source As TSource
    Public Property Source As TSource
        Get
            Return _source
        End Get
        Set(value As TSource)
            _source = value
            UpdateGroups(value)
        End Set
    End Property

    Public ReadOnly Property Group As New ObservableCollection(Of ObservableGrouping(Of TKey, TValue))

    Private Sub UpdateGroups(src As TSource)
        If _groupHandlerRegistered Then
            RemoveHandler Source.CollectionChanged, AddressOf OnSourceChanged
            For Each s In Source
                RemoveHandler s.KeyChanged, AddressOf OnKeyChanged
            Next
            _groupHandlerRegistered = False
        End If
        If src Is Nothing Then Return
        ResetGroup(src)
        AddHandler src.CollectionChanged, AddressOf OnSourceChanged
        For Each s In Source
            AddHandler s.KeyChanged, AddressOf OnKeyChanged
        Next
        _groupHandlerRegistered = True
    End Sub

    Private Sub OnKeyChanged(sender As Object, e As KeyChangedEventArgs(Of TKey))
        Dim fromCollection = Aggregate g In Group
                             Where Equals(g.Key, e.OldKey)
                             Into First
        fromCollection.Values.Remove(e.Item)
        If fromCollection.Values.Count = 0 Then
            Group.Remove(fromCollection)
        End If
        Dim toCollection = Aggregate g In Group
                           Where Equals(g.Key, e.NewKey)
                           Into FirstOrDefault
        If toCollection Is Nothing Then
            toCollection = New ObservableGrouping(Of TKey, TValue)(e.NewKey, Nothing)
        End If
        toCollection.Values.Add(e.Item)
    End Sub

    Private Sub ResetGroup(src As TSource)
        Dim grouped = From s In src
                      Group By s.Key Into Group
                      Select New ObservableGrouping(Of TKey, TValue)(Key, Group)
        _Group = New ObservableCollection(Of ObservableGrouping(Of TKey, TValue))(grouped)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Group)))
    End Sub

    Private Sub OnSourceChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
        Dim reason = e.Action
        If reason = NotifyCollectionChangedAction.Add Then
            Dim newItems = e.NewItems
            If newItems.Count > 1 Then
                Dim grouped = From v As TValue In newItems
                              Group By v.Key Into Group
                Dim addGrouped =
                    Sub()
                        For Each g In grouped
                            Group.Add(New ObservableGrouping(Of TKey, TValue)(g.Key, g.Group))
                        Next
                    End Sub
                If Group.Count = 0 Then
                    addGrouped()
                Else
                    Dim lastGroup = Group(Group.Count - 1)
                    Dim first = grouped.First
                    If lastGroup.Key.Equals(first.Key) Then
                        Dim lastValues = lastGroup.Values
                        For Each f In first.Group
                            lastValues.Add(f)
                        Next
                        Dim rest = grouped.Skip(1)
                        For Each g In rest
                            Group.Add(New ObservableGrouping(Of TKey, TValue)(g.Key, g.Group))
                        Next
                    Else
                        addGrouped()
                    End If
                End If
            ElseIf newItems.Count = 1 Then
                ' 优化这个热路径。项目基本上都是一个个添加的。
                Dim newItem = DirectCast(newItems(0), TValue)
                If Group.Count = 0 Then
                    Group.Add(New ObservableGrouping(Of TKey, TValue)(newItem.Key, {newItem}))
                Else
                    Dim lastGroup = Group(Group.Count - 1)
                    If lastGroup.Key.Equals(newItem.Key) Then
                        lastGroup.Values.Add(newItem)
                    Else
                        Group.Add(New ObservableGrouping(Of TKey, TValue)(newItem.Key, {newItem}))
                    End If
                End If
            End If
        Else
            ' 其它操作对于即时消息而言较为少见。采取性能最差的做法。
            ResetGroup(Source)
        End If
    End Sub
End Class
