Public Class EditTextBox
    Inherits EditorControl

    Private ReadOnly _singleLineEditTemplate As New DataTemplate(AddressOf CreateEntry)
    Private ReadOnly _multipleLineEditTemplate As New DataTemplate(AddressOf CreateEditor)

    Protected Overridable Function CreateEntry() As Entry
        Dim ent As New Entry
        ent.SetBinding(Entry.TextProperty, New Binding("Text", source:=Me, mode:=BindingMode.TwoWay))
        Return ent
    End Function

    Protected Overridable Function CreateEditor() As Editor
        Dim ent As New Editor With {.HeightRequest = 120}
        ent.SetBinding(Editor.TextProperty, New Binding("Text", source:=Me, mode:=BindingMode.TwoWay))
        Return ent
    End Function

    Public Property AcceptsReturn As Boolean
        Get
            Return GetValue(AcceptsReturnProperty)
        End Get
        Set
            SetValue(AcceptsReturnProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly AcceptsReturnProperty As BindableProperty =
                           BindableProperty.Create(NameOf(AcceptsReturn),
                           GetType(Boolean), GetType(EditTextBox), False,
                           propertyChanged:=
                           Sub(bindable, oldValue, newValue)
                               Dim this = DirectCast(bindable, EditTextBox)
                               Dim old = DirectCast(oldValue, Boolean)
                               Dim newVal = DirectCast(newValue, Boolean)
                               If old <> newVal Then
                                   this.UpdateEditTemplate()
                               End If
                           End Sub)

    Private Sub UpdateEditTemplate()
        EditContentTemplate = If(AcceptsReturn, _multipleLineEditTemplate, _singleLineEditTemplate)
    End Sub

    Public Property Text As String
        Get
            Return GetValue(TextProperty)
        End Get
        Set
            SetValue(TextProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly TextProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Text),
                           GetType(String), GetType(EditTextBox),
                           String.Empty, defaultBindingMode:=BindingMode.TwoWay,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, EditTextBox)
                                                Dim old = DirectCast(oldValue, String)
                                                Dim newVal = DirectCast(newValue, String)
                                                If old <> newVal Then
                                                    this.InnerContent = newVal
                                                    this.lblText.Text = newVal
                                                End If
                                            End Sub)

    Dim lblText As New Label
    Sub New()
        ViewContentTemplate = New DataTemplate(AddressOf CreateTextBlock)
        UpdateEditTemplate()
    End Sub

    Private Function CreateTextBlock() As Label
        Return lblText
    End Function
End Class
