Public MustInherit Class ChatItemBase
    Implements IKeyIndexable(Of Date)

    Private _DateTime As Date
    Public Property Id As Guid
    Public Property OwnerUserId As Integer
    Public Property ChatSessionId As Integer
    Public Property Placement As ChatItemPlacement ' 并非网络传输而来。需要自行获取用户信息判断。
    Public Property Header As String
    Public Property Icon As Uri
    Public Property IsCheckedInParentConference As Boolean?

    Public Property DateTime As Date Implements IKeyIndexable(Of Date).Key
        Get
            Return _DateTime
        End Get
        Set
            Dim changed = _DateTime <> Value
            If changed Then
                Dim old = _DateTime
                _DateTime = Value
                RaiseEvent KeyChanged(Me, New KeyChangedEventArgs(Of Date)(old, Value, Me))
            End If
        End Set
    End Property

    Public Event KeyChanged As EventHandler(Of KeyChangedEventArgs(Of Date)) Implements IKeyIndexable(Of Date).KeyChanged
    Public MustOverride Function ToBriefString() As String
End Class
