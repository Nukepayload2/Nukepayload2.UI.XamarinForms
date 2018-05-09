Public Class ComboBox
    Inherits Primitives.Selector

    Private Sub CtlButtonPartWithEvents_Tapped(sender As Object, e As EventArgs) Handles CtlButtonPartWithEvents.Tapped
        IsExpanded = Not IsExpanded
    End Sub

    Private Sub LstFlyoutWithEvents_ChildAdded(sender As Object, e As ElementEventArgs) Handles LstFlyoutWithEvents.ChildAdded
        Dim itm = DirectCast(e.Element, ComboBoxItem)
        AddHandler itm.Tapped, AddressOf OnSelectedItemChanging
    End Sub

    Private Sub LstFlyoutWithEvents_ChildRemoved(sender As Object, e As ElementEventArgs) Handles LstFlyoutWithEvents.ChildRemoved
        Dim itm = DirectCast(e.Element, ComboBoxItem)
        RemoveHandler itm.Tapped, AddressOf OnSelectedItemChanging
    End Sub

    Protected Sub OnSelectedItemChanging(sender As Object, e As EventArgs)
        Dim itm = DirectCast(sender, ComboBoxItem)
        SelectedItem = itm.InnerContent
    End Sub

    Protected Overrides Sub OnSelectedItemChanged(oldValue As Object, newValue As Object)
        If newValue IsNot Nothing Then
            ItmContent.InnerContent = newValue
            ItmContent.UpdateContent()
            Dim children = LstFlyout.Children
            Dim models = LstFlyout.ItemsSource
            If models IsNot Nothing Then
                Dim i = 0
                Dim found = False
                For Each mdl In models
                    If Equals(mdl, newValue) Then
                        found = True
                        Exit For
                    End If
                    i += 1
                Next
                If found Then
                    SelectedIndex = i
                End If
            End If
            IsExpanded = False
        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(oldValue As Integer, newValue As Integer)
        Dim children = LstFlyout.Children
        If oldValue >= 0 Then
            Dim oldControl = DirectCast(children(oldValue), ComboBoxItem)
            oldControl.IsSelected = False
        End If
        If newValue < 0 Then
            SelectedItem = Nothing
        Else
            Dim newControl = DirectCast(children(newValue), ComboBoxItem)
            newControl.IsSelected = True
            SelectedItem = newControl.InnerContent
        End If
    End Sub

    Protected Overrides Sub OnItemsSourceChanged(oldValue As IEnumerable, newValue As IEnumerable)
        MyBase.OnItemsSourceChanged(oldValue, newValue)
        SelectedIndex = -1
        LstFlyout.ItemsSource = newValue
    End Sub

    Protected Overrides Sub OnItemTemplateChanged(oldValue As DataTemplate, newValue As DataTemplate)
        MyBase.OnItemTemplateChanged(oldValue, newValue)
        ItmContent.ContentTemplate = newValue
        LstFlyout.ItemTemplate = WrapDataTemplate(Of ComboBoxItem)()
    End Sub

    Protected Overrides Sub OnItemTemplateSelectorChanged(old As DataTemplateSelector, newValue As DataTemplateSelector)
        MyBase.OnItemTemplateSelectorChanged(old, newValue)
        ItmContent.ContentTemplateSelector = newValue
        LstFlyout.ItemTemplateSelector = WrapDataTemplateSelector(Of ComboBoxItem)()
    End Sub

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
                           GetType(Boolean), GetType(ComboBox),
                           False, propertyChanged:=
                           Sub(bindable, oldValue, newValue)
                               Dim this = DirectCast(bindable, ComboBox)
                               Dim old = DirectCast(oldValue, Boolean)
                               Dim newVal = DirectCast(newValue, Boolean)
                               If old <> newVal Then
                                   this.ScrFlyout.IsVisible = newVal
                                   this.LblArrow.RotateTo(If(newVal, 180, 0), easing:=Easing.CubicOut)
                                   Dim flyout = FlyoutBase.GetAttachedFlyout(this)
                                   If newVal Then
                                       If this.FlyoutContainer Is Nothing Then
                                           Debug.WriteLine("Warning: FlyoutContainer was not specified. ComboBox is trying to get the last FlyoutContainer instance.")
                                           Dim container = FlyoutContainer.LastInstance
                                           If container Is Nothing Then
                                               Throw New InvalidOperationException("Can't expand if FlyoutContainer is nether assigned nor put on the same page.")
                                           End If
                                           ' 已知问题: 上一个视图的 FlyoutContainer 如果没有被 GC 回收，这个实例仍然会存活。
                                           ' 并且 ComboBox 会无法弹出，同时不会产生正确的异常信息。
                                           ' 如果当前视图忘记放置 FlyoutContainer 控件，就会导致上一个视图的 FlyoutContainer 控件不能释放。
                                           ' 如果代码没有犯那样的错，这个逻辑就没有问题。
                                           flyout.FlyoutContainer = container
                                       End If
                                       flyout.Show()
                                   Else
                                       flyout.Hide()
                                   End If
                               End If
                           End Sub)

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
                           GetType(FlyoutContainer), GetType(ComboBox),
                           Nothing, propertyChanged:=
                           Sub(bindable, oldValue, newValue)
                               Dim this = DirectCast(bindable, ComboBox)
                               Dim old = DirectCast(oldValue, FlyoutContainer)
                               Dim newVal = DirectCast(newValue, FlyoutContainer)
                               If old IsNot newVal Then
                                   this.FlyItemPicker.FlyoutContainer = newVal
                               End If
                           End Sub)

    Private Sub FlyItemPickerWithEvents_Hidden(sender As Object, e As EventArgs) Handles FlyItemPickerWithEvents.Hidden
        IsExpanded = False
    End Sub

    Private Sub FlyItemPickerWithEvents_Shown(sender As Object, e As EventArgs) Handles FlyItemPickerWithEvents.Shown
        IsExpanded = True
    End Sub
End Class
