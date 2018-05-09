Option Strict On

Imports Android.App
Imports Android.Content
Imports Android.Locations
Imports Android.OS
Imports Android.Runtime
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(ILocationManager))>
Friend Class AndroidLocationManager
    Implements ILocationManager

    Private _locationManager As LocationManager
    Private _locationProvider As String
    Private _lastLocation As Location
    Private WithEvents Listener As New LocationEventsAdapter

    Private Sub Listener_LocationUpdated(sender As Object, e As LocationChangedEventArgs) Handles Listener.LocationUpdated
        _lastLocation = e.Location
    End Sub

    Public Async Function GetLocationAsync() As Task(Of (Latitude As Double, Longitude As Double)?) Implements ILocationManager.GetLocationAsync
        Dim currentActivity As Activity = MyApplication.CurrentActivity
        Try
            If _locationManager Is Nothing Then
                _locationManager = DirectCast(currentActivity.GetSystemService(Context.LocationService), LocationManager)
                Dim criteriaForLocationService As New Criteria With {
                    .Accuracy = Accuracy.Fine
                }
                _locationProvider = _locationManager.GetProviders(criteriaForLocationService, True).FirstOrDefault
            End If
            If _locationProvider <> Nothing Then
                _lastLocation = Nothing
                _locationManager.RequestLocationUpdates(_locationProvider, 0, 0, Listener)
                Await WaitForLocationAsync()
                Dim loc = _lastLocation
                _locationManager.RemoveUpdates(Listener)
                Return (loc.Latitude, loc.Longitude)
            End If
        Catch ex As Java.Lang.SecurityException
            Diagnostics.Debug.WriteLine("定位失败：" + ex.Message)
        End Try
        Return Nothing
    End Function

    Private Async Function WaitForLocationAsync() As Task
        Do While _lastLocation Is Nothing
            Await Task.Delay(100)
        Loop
    End Function

    Private Class LocationEventsAdapter
        Inherits Java.Lang.Object
        Implements ILocationListener

        Public Event LocationUpdated As EventHandler(Of LocationChangedEventArgs)

        Public Sub OnLocationChanged(location As Location) Implements ILocationListener.OnLocationChanged
            RaiseEvent LocationUpdated(Me, New LocationChangedEventArgs(location))
        End Sub

        Public Sub OnProviderDisabled(provider As String) Implements ILocationListener.OnProviderDisabled
        End Sub

        Public Sub OnProviderEnabled(provider As String) Implements ILocationListener.OnProviderEnabled
        End Sub

        Public Sub OnStatusChanged(provider As String, <GeneratedEnum> status As Availability, extras As Bundle) Implements ILocationListener.OnStatusChanged
        End Sub
    End Class
End Class
