Imports Android.App
Imports Android.Content
Imports Android.Support.V4.App
Imports Android.Widget
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(IInteraction))>
Friend Class AndroidInteraction
    Implements IInteraction

    Public Async Function MsgBoxAsync(prompt As String, Optional hasCancel As Boolean = False, Optional title As String = Nothing, Optional oK As String = "确定", Optional cancel As String = "取消") As Task(Of Boolean?) Implements IInteraction.MsgBoxAsync
        Dim ab As New AlertDialog.Builder(MyApplication.CurrentActivity)
        If title Is Nothing Then
            title = MyApplication.CurrentActivity.Title
        End If
        Dim result As Boolean?
        Dim waitingClosure As New MsgBoxAsyncClosure
        With ab
            .SetTitle(title)
            .SetMessage(prompt)
            .SetPositiveButton(oK, Sub() result = True)
            If hasCancel Then
                .SetNegativeButton(cancel, Sub() result = False)
            End If
            ' Xamarin 没有做委托重载?
            .SetOnDismissListener(waitingClosure)
        End With
        ab.Show()
        Do While waitingClosure.Waiting
            Await Task.Delay(100)
        Loop
        Return result
    End Function

    Private Class MsgBoxAsyncClosure
        Inherits Java.Lang.Object
        Implements IDialogInterfaceOnDismissListener

        Public Waiting As Boolean = True

        Public Sub OnDismiss(dialog As IDialogInterface) Implements IDialogInterfaceOnDismissListener.OnDismiss
            Waiting = False
        End Sub
    End Class

    Public Async Function InputBoxAsync(prompt As String, Optional title As String = Nothing, Optional defaultValue As String = Nothing) As Task(Of String) Implements IInteraction.InputBoxAsync
        Dim ab As New AlertDialog.Builder(MyApplication.CurrentActivity)
        If title Is Nothing Then
            title = MyApplication.CurrentActivity.Title
        End If
        Dim result As Boolean?
        Dim waitingClosure As New InputBoxAsyncClosure
        Dim txtInput As New EditText(MyApplication.CurrentActivity)
        With ab
            .SetTitle(title)
            .SetMessage(prompt)
            .SetPositiveButton("确定", Sub() result = True)
            .SetNegativeButton("取消", Sub() result = False)
            .SetView(txtInput)
            .SetOnDismissListener(waitingClosure)
        End With
        ab.Show()
        Do While waitingClosure.Waiting
            Await Task.Delay(100)
        Loop
        Return If(result, txtInput.Text, defaultValue)
    End Function

    Private Class InputBoxAsyncClosure
        Inherits Java.Lang.Object
        Implements IDialogInterfaceOnDismissListener

        Public Waiting As Boolean = True

        Public Sub OnDismiss(dialog As IDialogInterface) Implements IDialogInterfaceOnDismissListener.OnDismiss
            Waiting = False
        End Sub
    End Class

    Private s_notificationId As Integer = 1
    Public Sub NotifyIcon(prompt As String, Optional title As String = Nothing) Implements IInteraction.NotifyIcon
        Dim curActivity = MyApplication.CurrentActivity
        If title Is Nothing Then
            title = curActivity.Title
        End If
        Dim intent As New Intent(curActivity, curActivity.GetType)
        With New NotificationCompat.Builder(curActivity)
            .SetTicker(prompt)
            .SetContentText(prompt)
            .SetContentTitle(title)
            .SetSmallIcon(MyApplication.IconId)
            Dim manager = CType(curActivity.GetSystemService(Context.NotificationService), NotificationManager)
            manager.Notify(s_notificationId, .Build())
            s_notificationId += 1
        End With
    End Sub

End Class
