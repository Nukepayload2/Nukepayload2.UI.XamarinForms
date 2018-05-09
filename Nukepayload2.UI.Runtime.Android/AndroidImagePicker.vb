Option Compare Text

Imports Android.Content
Imports AndroidResult = Android.App.Result
Imports AndroidUri = Android.Net.Uri
Imports System.IO
Imports Android.Provider
Imports Android.Database
Imports Android.OS
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(IImageFilePicker))>
Friend Class AndroidImagePicker
    Implements IImageFilePicker

    Friend Const ImagePickerRequestCode = 101
    Friend Shared _waitingForComplete As Boolean
    Friend Shared _result As String

    Friend Async Function PickAndOpenForReadAsync() As Task(Of Stream) Implements IImageFilePicker.PickAndOpenForReadAsync
        Await WhenLastPickComplete()
        Dim intent As New Intent(Intent.ActionGetContent)
        intent.SetType("image/png;image/jpeg")
        intent.AddCategory(Intent.CategoryOpenable)
        MyApplication.CurrentActivity.StartActivityForResult(intent, ImagePickerRequestCode)
        _waitingForComplete = True
        Await WhenLastPickComplete()
        If _result Is Nothing Then Return Nothing
        Return File.OpenRead(_result)
    End Function

    Private Shared Async Function WhenLastPickComplete() As Task
        Do While _waitingForComplete
            Await Task.Delay(100)
        Loop
    End Function

    Friend Shared Function GetFileAbsolutePath(fileUri As AndroidUri) As String
        Dim context = MyApplication.CurrentActivity
        If context Is Nothing OrElse fileUri Is Nothing Then Return Nothing
        If Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat AndAlso DocumentsContract.IsDocumentUri(context, fileUri) Then
            Select Case fileUri.Authority
                Case "com.android.externalstorage.documents"
                    Dim docId As String = DocumentsContract.GetDocumentId(fileUri)
                    Dim split As String() = docId.Split(":"c)
                    Dim type As String = split(0)
                    If "primary" = type Then
                        Return Environment.ExternalStorageDirectory.Path & "/" + split(1)
                    End If
                Case "com.android.providers.downloads.documents"
                    Dim id As String = DocumentsContract.GetDocumentId(fileUri)
                    Dim contentUri = ContentUris.WithAppendedId(AndroidUri.Parse("content://downloads/public_downloads"), id)
                    Return GetDataColumn(context, contentUri, Nothing, Nothing)
                Case "com.android.providers.media.documents"
                    Dim docId As String = DocumentsContract.GetDocumentId(fileUri)
                    Dim split As String() = docId.Split(":"c)
                    Dim type As String = split(0)
                    Dim contentUri As AndroidUri = Nothing
                    Select Case type
                        Case "image"
                            contentUri = MediaStore.Images.Media.ExternalContentUri
                        Case "video"
                            contentUri = MediaStore.Video.Media.ExternalContentUri
                        Case "audio"
                            contentUri = MediaStore.Audio.Media.ExternalContentUri
                    End Select
                    Dim selection = MediaStore.Images.Media.InterfaceConsts.Id & "=?"
                    Dim selectionArgs = {split(1)}
                    Return GetDataColumn(context, contentUri, selection, selectionArgs)
            End Select
        Else
            Select Case fileUri.Scheme
                Case "content"
                    If fileUri.Authority = "com.google.android.apps.photos.content" Then
                        Return fileUri.LastPathSegment
                    End If
                    Return GetDataColumn(context, fileUri, Nothing, Nothing)
                Case "file"
                    Return fileUri.Path
            End Select
        End If
        Return Nothing
    End Function

    Friend Shared Function GetDataColumn(context As Context, uri As AndroidUri, selection As String, selectionArgs As String()) As String
        Dim cursor As ICursor = Nothing
        Dim projection As String() = {MediaStore.Images.Media.InterfaceConsts.Data}
        Try
            cursor = context.ContentResolver.Query(uri, projection, selection, selectionArgs, Nothing)
            If cursor IsNot Nothing AndAlso cursor.MoveToFirst() Then
                Dim index As Integer = cursor.GetColumnIndexOrThrow(MediaStore.Images.Media.InterfaceConsts.Data)
                Return cursor.GetString(index)
            End If
        Finally
            If cursor IsNot Nothing Then cursor.Close()
        End Try
        Return Nothing
    End Function

End Class

Public Class AndroidImagePickerHandler

    Public Shared Sub OnActivityResult(requestCode As Integer, resultCode As AndroidResult, data As Intent)
        If requestCode = AndroidImagePicker.ImagePickerRequestCode Then
            If resultCode = AndroidResult.Ok Then
                AndroidImagePicker._result = AndroidImagePicker.GetFileAbsolutePath(data.Data)
            End If
            AndroidImagePicker._waitingForComplete = False
        End If
    End Sub

End Class