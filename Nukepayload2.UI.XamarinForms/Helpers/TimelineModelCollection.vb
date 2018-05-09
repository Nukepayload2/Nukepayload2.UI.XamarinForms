Imports System.Collections.ObjectModel

Public Class TimelineModelCollection
    Inherits ObservableCollection(Of TimelineModelBase)
    Implements ICloneable(Of TimelineModelCollection)

    Public Sub New()
    End Sub

    Public Sub New(items As IEnumerable(Of TimelineModelBase))
        MyBase.New(items)
    End Sub

    Public Function Clone() As TimelineModelCollection Implements ICloneable(Of TimelineModelCollection).Clone
        If Count = 0 Then
            Return New TimelineModelCollection
        End If
        Dim itms(Count - 1) As TimelineModelBase
        For i = 0 To Count - 1
            itms(i) = Me(i).Clone
        Next
        Return New TimelineModelCollection(itms)
    End Function

    Public Sub AddRange(timeline As TimelineModelBase())
        If timeline IsNot Nothing Then
            For Each tl In timeline
                Add(tl)
            Next
        End If
    End Sub
End Class
