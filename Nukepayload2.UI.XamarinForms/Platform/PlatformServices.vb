Imports System.IO

Namespace Global.Nukepayload2.UI.Platform

    Public Interface IApplication2
        Sub Shutdown()
    End Interface

    Public Interface IImageFilePicker
        Function PickAndOpenForReadAsync() As Task(Of Stream)
    End Interface

    Public Interface ILocalStorageService
        Function OpenOrCreateFileAsync(fileName As String) As Task(Of Stream)
    End Interface

    ''' <summary>
    ''' 包含常用的交互逻辑。
    ''' </summary>
    Public Interface IInteraction
        Function MsgBoxAsync(prompt As String,
                             Optional hasCancel As Boolean = False,
                             Optional title As String = Nothing,
                             Optional oK As String = "确定",
                             Optional cancel As String = "取消") As Task(Of Boolean?)
        Function InputBoxAsync(prompt As String,
                               Optional title As String = Nothing,
                               Optional defaultValue As String = Nothing) As Task(Of String)
        ''' <summary>
        ''' 在 Windows 10 显示 Toast 通知, 在 Android 显示 NotificationCompact。将在通知开始显示时立即返回，不等待其消失。这种通知会出现在通知中心中，点击后会将这个应用带到前台。
        ''' </summary>
        ''' <param name="prompt">正文</param>
        ''' <param name="title">标题</param>
        Sub NotifyIcon(prompt As String,
                       Optional title As String = Nothing)
    End Interface

    Public Interface ILocationManager
        Function GetLocationAsync() As Task(Of (Latitude As Double, Longitude As Double)?)
    End Interface
End Namespace