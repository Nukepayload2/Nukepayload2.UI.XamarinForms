Public MustInherit Class FlyoutBase
    Inherits ContentView

    Private _isShown As Boolean
    Private _prevFlyoutContainer As FlyoutContainer

    Public Overridable Sub Show()
        If _isShown Then
            Return
        End If
        Dim container = FlyoutContainer
        If container Is Nothing Then
            Throw New InvalidOperationException("Unable to show flyout: FlyoutContainer is null (Nothing in Visual Basic).")
        End If
        _prevFlyoutContainer = container
        container.Flyout = Me
        _isShown = True
        OnShown()
    End Sub

    Public Event Shown As EventHandler

    Protected Overridable Sub OnShown()
        RaiseEvent Shown(Me, EventArgs.Empty)
    End Sub

    Public Overridable Sub Hide()
        If Not _isShown Then
            Return
        End If
        Dim container = FlyoutContainer
        If container IsNot _prevFlyoutContainer Then
            Throw New InvalidOperationException("FlyoutContainer was changed during show.")
        End If
        _prevFlyoutContainer = Nothing
        container.Flyout = Nothing
        _isShown = False
        OnHidden()
    End Sub

    Public Event Hidden As EventHandler

    Protected Overridable Sub OnHidden()
        RaiseEvent Hidden(Me, EventArgs.Empty)
    End Sub

    Public ReadOnly Property IsShown As Boolean
        Get
            Return _isShown
        End Get
    End Property

    Public Property FlyoutContainer As FlyoutContainer
        Get
            Return GetValue(FlyoutContainerProperty)
        End Get
        Set
            SetValue(FlyoutContainerProperty, Value)
        End Set
    End Property

    Public Shared ReadOnly FlyoutContainerProperty As BindableProperty =
                           BindableProperty.Create(NameOf(FlyoutContainer),
                           GetType(FlyoutContainer), GetType(FlyoutBase),
                           Nothing)

    Public Shared Function GetAttachedFlyout(element As BindableObject) As FlyoutBase
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        Return element.GetValue(AttachedFlyoutProperty)
    End Function

    Public Shared Sub SetAttachedFlyout(element As BindableObject, value As FlyoutBase)
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        element.SetValue(AttachedFlyoutProperty, value)
    End Sub

    Public Shared ReadOnly AttachedFlyoutProperty As _
                           BindableProperty = BindableProperty.CreateAttached("AttachedFlyout",
                           GetType(FlyoutBase), GetType(FlyoutBase),
                           Nothing)

    Public Property IsModal As Boolean
        Get
            Return GetValue(IsModalProperty)
        End Get
        Set
            SetValue(IsModalProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsModalProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsModal),
                           GetType(Boolean), GetType(FlyoutBase),
                           False)

End Class
