Namespace Primitives

    Public MustInherit Class Selector
        Inherits ItemsControl

        Public Property SelectedItem As Object
            Get
                Return GetValue(SelectedItemProperty)
            End Get
            Set
                SetValue(SelectedItemProperty, Value)
            End Set
        End Property
        Public Shared ReadOnly SelectedItemProperty As BindableProperty =
                               BindableProperty.Create(NameOf(SelectedItem),
                               GetType(Object), GetType(Selector),
                               Nothing, defaultBindingMode:=BindingMode.TwoWay, propertyChanged:=
                               Sub(bindable, oldValue, newValue)
                                   Dim this = DirectCast(bindable, Selector)
                                   If oldValue IsNot newValue Then
                                       this.OnSelectedItemChanged(oldValue, newValue)
                                       this.OnItemSelected(New SelectedItemChangedEventArgs(newValue))
                                   End If
                               End Sub)

        Protected Overridable Sub OnItemSelected(e As SelectedItemChangedEventArgs)
            RaiseEvent ItemSelected(Me, e)
        End Sub

        Public Event ItemSelected As EventHandler(Of SelectedItemChangedEventArgs)

        Protected MustOverride Sub OnSelectedItemChanged(oldValue As Object, newValue As Object)

        Public Property SelectedIndex As Integer
            Get
                Return GetValue(SelectedIndexProperty)
            End Get
            Set
                SetValue(SelectedIndexProperty, Value)
            End Set
        End Property
        Public Shared ReadOnly SelectedIndexProperty As BindableProperty =
                               BindableProperty.Create(NameOf(SelectedIndex),
                               GetType(Integer), GetType(Selector),
                               -1, defaultBindingMode:=BindingMode.TwoWay, propertyChanged:=
                               Sub(bindable, oldValue, newValue)
                                   Dim this = DirectCast(bindable, Selector)
                                   Dim old = DirectCast(oldValue, Integer)
                                   Dim newVal = DirectCast(newValue, Integer)
                                   If old <> newVal Then
                                       this.OnSelectedIndexChanged(old, newVal)
                                   End If
                               End Sub)

        Protected MustOverride Sub OnSelectedIndexChanged(oldValue As Integer, newValue As Integer)

        Protected Class SelectorWrappedDataTemplate
            Inherits DataTemplate
            Public Sub New(loadTemplate As Func(Of Object))
                MyBase.New(loadTemplate)
            End Sub
        End Class

        Protected Overridable Function WrapDataTemplate(Of TChild As {ContentControl, New})() As DataTemplate
            Return New SelectorWrappedDataTemplate(
            Function()
                Dim itm As New TChild
                itm.SetBinding(ContentControl.InnerContentProperty, New Binding("."))
                itm.SetBinding(ContentControl.ContentTemplateProperty, New Binding("ItemTemplate", source:=Me))
                itm.SetBinding(ContentControl.ContentTemplateSelectorProperty, New Binding("ItemTemplateSelector", source:=Me))
                Return itm
            End Function)
        End Function

        Protected Class SelectorWrappedDataTemplateSelector(Of TChild As {ContentControl, New})
            Inherits DataTemplateSelector

            Private _selector As Selector

            Public Sub New(selector As Selector)
                _selector = selector
            End Sub

            Protected Overrides Function OnSelectTemplate(item As Object, container As BindableObject) As DataTemplate
                Return _selector.WrapDataTemplate(Of TChild)()
            End Function
        End Class

        Protected Overridable Function WrapDataTemplateSelector(Of TChild As {ContentControl, New})() As DataTemplateSelector
            Return New SelectorWrappedDataTemplateSelector(Of TChild)(Me)
        End Function

    End Class

End Namespace