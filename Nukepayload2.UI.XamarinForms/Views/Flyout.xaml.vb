Public Class Flyout
    Inherits FlyoutBase

    Public Property InnerContent As View
        Get
            Return GetValue(InnerContentProperty)
        End Get
        Set
            SetValue(InnerContentProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly InnerContentProperty As BindableProperty =
                           BindableProperty.Create(NameOf(InnerContent),
                           GetType(View), GetType(Flyout),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, Flyout)
                                                Dim old = DirectCast(oldValue, View)
                                                Dim newVal = DirectCast(newValue, View)
                                                If old IsNot newVal Then
                                                    this.CtlInner.Content = newVal
                                                End If
                                            End Sub)
End Class
