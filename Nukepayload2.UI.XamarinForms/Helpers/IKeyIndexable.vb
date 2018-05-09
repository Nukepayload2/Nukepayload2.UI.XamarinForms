Public Interface IKeyIndexable(Of TKey)
    ReadOnly Property Key As TKey
    Event KeyChanged As EventHandler(Of KeyChangedEventArgs(Of TKey))
End Interface

Public Class KeyChangedEventArgs(Of TKey)
    Inherits EventArgs

    Public Sub New(oldKey As TKey, newKey As TKey, item As IKeyIndexable(Of TKey))
        Me.OldKey = oldKey
        Me.NewKey = newKey
        Me.Item = item
    End Sub

    Public ReadOnly Property OldKey As TKey
    Public ReadOnly Property NewKey As TKey
    Public ReadOnly Property Item As IKeyIndexable(Of TKey)
End Class