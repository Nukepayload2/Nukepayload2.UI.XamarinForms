Imports System.IO
Imports Android.App
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(ILocalStorageService))>
Friend Class LocalStorageImpl
    Implements ILocalStorageService

    Public Async Function OpenOrCreateFileAsync(fileName As String) As Task(Of Stream) Implements ILocalStorageService.OpenOrCreateFileAsync
        Dim localData = Application.Context.FilesDir.Path
        Dim filePath = Path.Combine(localData, fileName)

        Return Await Task.Run(Function() File.Open(filePath, FileMode.OpenOrCreate))
    End Function

End Class
