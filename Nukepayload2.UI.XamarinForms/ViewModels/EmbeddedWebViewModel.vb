Imports System.ComponentModel

Namespace ViewModels

    Public Class EmbeddedWebViewModel
        Inherits Singleton(Of EmbeddedWebViewModel)
        Implements INotifyPropertyChanged

        Dim _Title As String
        Public Property Title As String
            Get
                Return _Title
            End Get
            Set(value As String)
                _Title = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Title)))
            End Set
        End Property

        Dim _NavigateUri As Uri
        Public Property NavigateUri As Uri
            Get
                Return _NavigateUri
            End Get
            Set(value As Uri)
                _NavigateUri = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(NavigateUri)))
            End Set
        End Property

        Dim _Cookies As String
        Public Property Cookies As String
            Get
                Return _Cookies
            End Get
            Set(value As String)
                _Cookies = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Cookies)))
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class

End Namespace