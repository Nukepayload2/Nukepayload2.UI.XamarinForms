
Imports Nukepayload2.UI.Platform


<PlatformImpl(GetType(IImageFilePicker))>
Friend Class UwpImagePickerImpl
    Implements IImageFilePicker

    Public Async Function PickAndOpenForReadAsync() As Task(Of Stream) Implements IImageFilePicker.PickAndOpenForReadAsync
        Dim picker As New Windows.Storage.Pickers.FileOpenPicker
        picker.FileTypeFilter.Add(".png")
        picker.FileTypeFilter.Add(".jpg")
        Dim picked = Await picker.PickSingleFileAsync
        If picked IsNot Nothing Then
            Return Await picked.OpenStreamForReadAsync
        End If
        Return Nothing
    End Function
End Class
