Imports Nukepayload2.UI.Platform

Imports Windows.Devices.Geolocation

<PlatformImpl(GetType(ILocationManager))>
Friend Class UwpLocationManager
    Implements ILocationManager

    Public Async Function GetLocationAsync() As Task(Of (latitude As Double, longitude As Double)?) Implements ILocationManager.GetLocationAsync
        Dim permission = Await Geolocator.RequestAccessAsync
        If permission = GeolocationAccessStatus.Allowed Then
            Dim loc As New Geolocator With {
                .DesiredAccuracyInMeters = 1000
            }
            Dim pos = Await loc.GetGeopositionAsync
            Dim posData = pos.Coordinate.Point.Position
            Return (posData.Latitude, posData.Longitude)
        End If
        Return Nothing
    End Function
End Class
