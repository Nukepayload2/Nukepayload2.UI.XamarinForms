Imports System.Timers

Public Class DispatcherTimer
    Private WithEvents InnerTimer As New Timer

    Public Property IsEnabled As Boolean
        Get
            Return InnerTimer.Enabled
        End Get
        Set(value As Boolean)
            InnerTimer.Enabled = value
        End Set
    End Property

    Public Property Interval As TimeSpan
        Get
            Return TimeSpan.FromMilliseconds(InnerTimer.Interval)
        End Get
        Set(value As TimeSpan)
            InnerTimer.Interval = value.TotalMilliseconds
        End Set
    End Property

    Public Sub Start()
        InnerTimer.Start()
    End Sub

    Public Sub [Stop]()
        InnerTimer.Stop()
    End Sub

    Private Sub InnerTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles InnerTimer.Elapsed
        Device.BeginInvokeOnMainThread(Sub() RaiseEvent Tick(Me, e))
    End Sub

    Public Event Tick As EventHandler
End Class
