Imports System.ComponentModel

Public Class TimelineDate
    Inherits TimelineModelBase
    Implements INotifyPropertyChanged

    Dim _Date As Date
    Public Property [Date] As Date
        Get
            Return _Date
        End Get
        Set
            If Not _Date.Equals(Value) Then
                _Date = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf([Date])))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Overrides Function Clone() As TimelineModelBase
        Return New TimelineDate With {
            .Date = [Date]
        }
    End Function
End Class
