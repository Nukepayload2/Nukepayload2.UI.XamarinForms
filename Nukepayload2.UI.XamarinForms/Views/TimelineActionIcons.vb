Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Enum TimelineActionIcons
    <Display(Name:="到达地点")>
    ChangeLocation
    <Display(Name:="开始签到")>
    BeginCheck
    <Display(Name:="签到结束")>
    EndCheck
    <Display(Name:="会中安排")>
    ConferenceAction
    <Display(Name:="会议结束")>
    CloseConference
    <Display(Name:="开始用餐")>
    Dinner
End Enum

Public Module TimelineActionIconExtensions
    Private ReadOnly s_iconNames As Dictionary(Of TimelineActionIcons, String)
    Sub New()
        s_iconNames = (From fld In GetType(TimelineActionIcons).GetRuntimeFields
                       Where fld.IsLiteral AndAlso fld.IsPublic
                       Select fld.GetCustomAttribute(Of DisplayAttribute).Name, Value = DirectCast(fld.GetValue(Nothing), TimelineActionIcons)).
                       ToDictionary(Function(o) o.Value, Function(o) o.Name)
    End Sub

    <Extension>
    Public Function GetDisplayName(icon As TimelineActionIcons) As String
        Return s_iconNames(icon)
    End Function
End Module