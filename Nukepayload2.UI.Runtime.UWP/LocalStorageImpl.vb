
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(ILocalStorageService))>
Friend Class LocalStorageImpl
    Implements ILocalStorageService

    Public Async Function OpenOrCreateFileAsync(fileName As String) As Task(Of Stream) Implements ILocalStorageService.OpenOrCreateFileAsync
        Dim localData = Windows.Storage.ApplicationData.Current.LocalFolder
        Dim file = Await localData.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.OpenIfExists)
        Return Await file.OpenStreamForWriteAsync
    End Function

End Class
