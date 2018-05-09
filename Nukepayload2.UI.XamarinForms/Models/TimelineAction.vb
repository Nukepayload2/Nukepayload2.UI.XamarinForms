Imports System.ComponentModel

Public Class TimelineAction
    Inherits TimelineModelBase
    Implements INotifyPropertyChanged

    Dim _Action As TimelineActionIcons
    Public Property Action As TimelineActionIcons
        Get
            Return _Action
        End Get
        Set
            If Not _Action.Equals(Value) Then
                _Action = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Action)))
            End If
        End Set
    End Property

    Dim _Description As String
    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Description)))
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Overrides Function Clone() As TimelineModelBase
        Return New TimelineAction With {
            .Action = Action,
            .Description = Description
        }
    End Function
End Class
