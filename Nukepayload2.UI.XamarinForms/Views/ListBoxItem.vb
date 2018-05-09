Public Class ListBoxItem
    Inherits ContentControl

    Private _gestures As New TapGestureRecognizer

    Sub New()
        GestureRecognizers.Add(_gestures)
        BackgroundColor = Color.WhiteSmoke
    End Sub

    Public Custom Event Tapped As EventHandler
        AddHandler(value As EventHandler)
            AddHandler _gestures.Tapped, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler _gestures.Tapped, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Property IsSelected As Boolean
        Get
            Return GetValue(IsSelectedProperty)
        End Get
        Set
            SetValue(IsSelectedProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly IsSelectedProperty As BindableProperty =
                           BindableProperty.Create(NameOf(IsSelected),
                           GetType(Boolean), GetType(ListBoxItem),
                           False,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ListBoxItem)
                                                Dim old = DirectCast(oldValue, Boolean)
                                                Dim newVal = DirectCast(newValue, Boolean)
                                                If old <> newVal Then
                                                    this.BackgroundColor = If(newVal, Color.LightGray, Color.WhiteSmoke)
                                                End If
                                            End Sub)

End Class
