
Imports Nukepayload2.UI.Platform

Imports Windows.UI.Notifications
Imports Windows.UI.Popups

<PlatformImpl(GetType(IInteraction))>
Friend Class UwpInteractionImpl
    Implements IInteraction

    Public Async Function MsgBoxAsync(prompt As String, Optional hasCancel As Boolean = False, Optional title As String = Nothing, Optional oK As String = "确定", Optional cancel As String = "取消") As Task(Of Boolean?) Implements IInteraction.MsgBoxAsync
        If title Is Nothing Then
            title = Package.Current.DisplayName
        End If
        Dim dlg As New MessageDialog(prompt, title)
        Dim result As Boolean?
        Dim msg As New MessageDialog(prompt, title)
        msg.Commands.Add(New UICommand(oK, Sub(command) result = True))
        msg.DefaultCommandIndex = 0
        If hasCancel Then
            msg.Commands.Add(New UICommand(cancel, Sub(command) result = False))
            msg.CancelCommandIndex = 1
        End If
        Dim tsk = msg.ShowAsync
        Await tsk
        Return result
    End Function

    Dim inputbox As New InputBox
    Public Async Function InputBoxAsync(prompt As String, Optional title As String = Nothing, Optional defaultValue As String = Nothing) As Task(Of String) Implements IInteraction.InputBoxAsync
        If title Is Nothing Then
            title = Package.Current.DisplayName
        End If
        Return Await inputbox.ShowAsync(prompt, title, defaultValue)
    End Function

    Public Sub NotifyIcon(prompt As String, Optional title As String = Nothing) Implements IInteraction.NotifyIcon
        If title Is Nothing Then
            title = Package.Current.DisplayName
        End If
        Dim notificationXml = <toast>
                                  <visual>
                                      <binding template="ToastGeneric">
                                          <text hint-maxLines="1"><%= title %></text>
                                          <text><%= prompt %></text>
                                      </binding>
                                  </visual>
                                  <audio src="ms-winsoundevent:Notification.Reminder"/>
                              </toast>
        Dim winRtXmlDoc As New Windows.Data.Xml.Dom.XmlDocument
        winRtXmlDoc.LoadXml(notificationXml.ToString)
        ToastNotificationManager.CreateToastNotifier().Show(New ToastNotification(winRtXmlDoc))
    End Sub
End Class
