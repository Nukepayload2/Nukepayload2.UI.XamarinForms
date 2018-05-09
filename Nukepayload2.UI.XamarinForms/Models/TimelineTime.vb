Imports System.ComponentModel
Imports Nukepayload2.UI.Xaml

Public Class TimelineTime
    Inherits TimelineModelBase
    Implements INotifyPropertyChanged

    Dim _Time As TimeSpan
    Public Property Time As TimeSpan
        Get
            Return _Time
        End Get
        Set
            If Not _Time.Equals(Value) Then
                _Time = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Time)))
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Overrides Function Clone() As TimelineModelBase
        Return New TimelineTime With {
            .Time = Time
        }
    End Function
End Class
