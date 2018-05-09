Imports System.Collections.Specialized

Public Class ListBox
    Inherits Primitives.Selector

    Private Sub ItemsContainer_ChildAdded(sender As Object, e As ElementEventArgs) Handles ItemsContainer.ChildAdded
        Dim itm = DirectCast(e.Element, ListBoxItem)
        AddHandler itm.Tapped, AddressOf OnSelectedItemChanging
    End Sub

    Private Sub ItemsContainer_ChildRemoved(sender As Object, e As ElementEventArgs) Handles ItemsContainer.ChildRemoved
        Dim itm = DirectCast(e.Element, ListBoxItem)
        RemoveHandler itm.Tapped, AddressOf OnSelectedItemChanging
    End Sub

    Protected Sub OnSelectedItemChanging(sender As Object, e As EventArgs)
        Dim itm = DirectCast(sender, ListBoxItem)
        SelectedItem = itm.InnerContent
    End Sub

    Protected Overrides Sub OnSelectedItemChanged(oldValue As Object, newValue As Object)
        If newValue IsNot Nothing Then
            Dim children = Me.Children
            Dim models = ItemsSource
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
        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(oldValue As Integer, newValue As Integer)
        Dim children = Me.Children
        If oldValue >= 0 Then
            If children.Count > oldValue Then
                Dim oldControl = DirectCast(children(oldValue), ListBoxItem)
                oldControl.IsSelected = False
            End If
        End If
        If newValue < 0 Then
            SelectedItem = Nothing
        Else
            Dim newControl = DirectCast(children(newValue), ListBoxItem)
            newControl.IsSelected = True
            SelectedItem = newControl.InnerContent
        End If
    End Sub

    Private _listeningCollectionChange As Boolean

    Protected Overrides Sub OnItemsSourceChanged(oldValue As IEnumerable, newValue As IEnumerable)
        MyBase.OnItemsSourceChanged(oldValue, newValue)
        If _listeningCollectionChange Then
            Dim oldCollection = DirectCast(oldValue, INotifyCollectionChanged)
            RemoveHandler oldCollection.CollectionChanged, AddressOf OnItemsSourceCollectionChanged
        End If
        If TypeOf newValue Is INotifyCollectionChanged Then
            Dim newCollection = DirectCast(newValue, INotifyCollectionChanged)
            AddHandler newCollection.CollectionChanged, AddressOf OnItemsSourceCollectionChanged
            _listeningCollectionChange = True
        Else
            _listeningCollectionChange = False
        End If
        SelectedIndex = -1
    End Sub

    Private Sub OnItemsSourceCollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
        Select Case e.Action
            Case NotifyCollectionChangedAction.Move
                If e.OldStartingIndex = SelectedIndex AndAlso e.OldItems.Count = 1 Then
                    SelectedIndex = e.NewStartingIndex
                Else
                    SelectedIndex = -1
                End If
            Case NotifyCollectionChangedAction.Remove
                If e.OldItems.Count = 1 Then
                    If e.OldStartingIndex = SelectedIndex Then
                        SelectedIndex = -1
                    ElseIf e.OldStartingIndex < SelectedIndex Then
                        SelectedIndex -= 1
                    End If
                Else
                    SelectedIndex = -1
                End If
            Case NotifyCollectionChangedAction.Replace
                If e.OldItems.Count = 1 Then
                    If e.NewStartingIndex = SelectedIndex Then
                        SelectedIndex = -1
                    End If
                Else
                    SelectedIndex = -1
                End If
            Case NotifyCollectionChangedAction.Reset
                SelectedIndex = -1
        End Select
    End Sub

    Protected Overridable Shadows Sub OnItemTemplateChanged(oldValue As DataTemplate, newValue As DataTemplate)
        MyBase.OnItemTemplateChanged(oldValue, newValue)
        MyBase.ItemTemplate = WrapDataTemplate(Of ListBoxItem)()
    End Sub

    Protected Overridable Shadows Sub OnItemTemplateSelectorChanged(old As DataTemplateSelector, newVal As DataTemplateSelector)
        MyBase.OnItemTemplateSelectorChanged(old, newVal)
        MyBase.ItemTemplateSelector = WrapDataTemplateSelector(Of ListBoxItem)()
    End Sub

    Public Shadows Property ItemTemplate As DataTemplate
        Get
            Return GetValue(ItemTemplateProperty)
        End Get
        Set
            SetValue(ItemTemplateProperty, Value)
        End Set
    End Property
    Public Shared Shadows ReadOnly ItemTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemTemplate),
                           GetType(DataTemplate), GetType(ListBox),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ListBox)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.OnItemTemplateChanged(old, newVal)
                                                End If
                                            End Sub)

    Public Shadows Property ItemTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(ItemTemplateSelectorProperty)
        End Get
        Set
            SetValue(ItemTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared Shadows ReadOnly ItemTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemTemplateSelector),
                           GetType(DataTemplateSelector), GetType(ListBox),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ListBox)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.OnItemTemplateSelectorChanged(old, newVal)
                                                End If
                                            End Sub)

    Sub New()
        Content = New ScrollView With {.Content = Content}
    End Sub
End Class
