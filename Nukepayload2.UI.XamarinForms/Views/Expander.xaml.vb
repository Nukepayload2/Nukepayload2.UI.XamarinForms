Public Class Expander
    Inherits ContentView

    Public Shared ReadOnly Property HeaderFoldedBackground As Color = Color.FromHex("#1F000000")
    Public Shared ReadOnly Property HeaderFoldedForeground As Color = Color.Black
    Public Shared ReadOnly Property HeaderExpandedBackground As Color = Color.DodgerBlue
    Public Shared ReadOnly Property HeaderExpandedForeground As Color = Color.WhiteSmoke

    Public Property IsExpanded As Boolean
        Get
            Return GetValue(IsExpandedProperty)
        End Get
        Set
            SetValue(IsExpandedProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsExpandedProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsExpanded),
                           GetType(Boolean), GetType(Expander), False,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Expander)
                                                Dim old = DirectCast(oldValue, Boolean)
                                                Dim newVal = DirectCast(newValue, Boolean)
                                                If old <> newVal Then
                                                    this.CtlContent.IsVisible = newVal
                                                    this.OnToggled()
                                                End If
                                            End Sub)

    Public Property Header As String
        Get
            Return GetValue(HeaderProperty)
        End Get
        Set
            SetValue(HeaderProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly HeaderProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Header),
                           GetType(String), GetType(Expander),
                           String.Empty,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Expander)
                                                Dim old = DirectCast(oldValue, String)
                                                Dim newVal = DirectCast(newValue, String)
                                                If old <> newVal Then
                                                    this.LblHeader.Text = If(newVal, String.Empty)
                                                End If
                                            End Sub)

    Public Property InnerContent As Object
        Get
            Return GetValue(InnerContentProperty)
        End Get
        Set
            SetValue(InnerContentProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly InnerContentProperty As BindableProperty =
                           BindableProperty.Create(NameOf(InnerContent),
                           GetType(Object), GetType(Expander),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Expander)
                                                If Not Equals(oldValue, newValue) Then
                                                    this.CtlContent.Content = newValue
                                                End If
                                            End Sub)

    Public Property HeaderBackground As Color
        Get
            Return GetValue(HeaderBackgroundProperty)
        End Get
        Set
            SetValue(HeaderBackgroundProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly HeaderBackgroundProperty As BindableProperty =
                           BindableProperty.Create(NameOf(HeaderBackground),
                           GetType(Color), GetType(Expander),
                           HeaderFoldedBackground,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Expander)
                                                Dim old = DirectCast(oldValue, Color)
                                                Dim newVal = DirectCast(newValue, Color)
                                                If old <> newVal Then
                                                    this.GrdBackground.BackgroundColor = newVal
                                                End If
                                            End Sub)

    Public Property HeaderForeground As Color
        Get
            Return GetValue(HeaderForegroundProperty)
        End Get
        Set
            SetValue(HeaderForegroundProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly HeaderForegroundProperty As BindableProperty =
                           BindableProperty.Create(NameOf(HeaderForeground),
                           GetType(Color), GetType(Expander),
                           HeaderFoldedForeground,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Expander)
                                                Dim old = DirectCast(oldValue, Color)
                                                Dim newVal = DirectCast(newValue, Color)
                                                If old <> newVal Then
                                                    this.LblHeader.TextColor = newVal
                                                    this.Arrow.TextColor = newVal
                                                End If
                                            End Sub)

    Protected Overridable Sub OnToggled()
        Dim exp = IsExpanded
        Arrow.RotateTo(If(exp, 90, 0), easing:=Easing.CubicOut)
        HeaderBackground = If(exp, HeaderExpandedBackground, HeaderFoldedBackground)
        HeaderForeground = If(exp, HeaderExpandedForeground, HeaderFoldedForeground)
        RaiseEvent Toggled(Me, EventArgs.Empty)
    End Sub

    Private Sub HeaderHitTestWithEvents_Tapped(sender As Object, e As EventArgs) Handles HeaderHitTestWithEvents.Tapped
        IsExpanded = Not IsExpanded
    End Sub

    ''' <summary>
    ''' 已切换打开状态
    ''' </summary>
    Public Event Toggled As EventHandler
End Class
