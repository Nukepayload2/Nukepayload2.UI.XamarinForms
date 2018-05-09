Imports System.Collections.Specialized

''' <summary>
''' 用于按照模板重复呈现一类集合。
''' </summary>
''' <remarks>受到 Xamarin 论坛帖子的启发编写。原帖地址：https://forums.xamarin.com/discussion/21635/xforms-needs-an-itemscontrol 。</remarks>
Public Class ItemsControl
    Inherits ContentView

    Protected WithEvents ItemsContainer As New StackLayout

    Public Shadows ReadOnly Property Children As IList(Of View)
        Get
            Return ItemsContainer.Children
        End Get
    End Property

    Public Shadows Custom Event ChildRemoved As EventHandler(Of ElementEventArgs)
        AddHandler(value As EventHandler(Of ElementEventArgs))
            AddHandler ItemsContainer.ChildRemoved, value
        End AddHandler
        RemoveHandler(value As EventHandler(Of ElementEventArgs))
            RemoveHandler ItemsContainer.ChildRemoved, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As ElementEventArgs)
        End RaiseEvent
    End Event

    Public Shadows Custom Event ChildAdded As EventHandler(Of ElementEventArgs)
        AddHandler(value As EventHandler(Of ElementEventArgs))
            AddHandler ItemsContainer.ChildAdded, value
        End AddHandler
        RemoveHandler(value As EventHandler(Of ElementEventArgs))
            AddHandler ItemsContainer.ChildAdded, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As ElementEventArgs)
        End RaiseEvent
    End Event

    Public Property Orientation As StackOrientation
        Get
            Return GetValue(OrientationProperty)
        End Get
        Set
            SetValue(OrientationProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly OrientationProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Orientation),
                           GetType(StackOrientation), GetType(ItemsControl),
                           StackOrientation.Vertical,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ItemsControl)
                                                Dim old = DirectCast(oldValue, StackOrientation)
                                                Dim newVal = DirectCast(newValue, StackOrientation)
                                                If old <> newVal Then
                                                    this.ItemsContainer.Orientation = newVal
                                                End If
                                            End Sub)

    Sub New()
        Content = ItemsContainer
    End Sub

    Public Property ItemsSource As IEnumerable
        Get
            Return GetValue(ItemsSourceProperty)
        End Get
        Set
            SetValue(ItemsSourceProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ItemsSourceProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemsSource),
                           GetType(IEnumerable), GetType(ItemsControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ItemsControl)
                                                Dim old = DirectCast(oldValue, IEnumerable)
                                                Dim newVal = DirectCast(newValue, IEnumerable)
                                                If old IsNot newVal Then
                                                    this.OnItemsChanged(old, newVal)
                                                    this.OnItemsSourceChanged(old, newVal)
                                                End If
                                            End Sub)

    Public Property ItemTemplate As DataTemplate
        Get
            Return GetValue(ItemTemplateProperty)
        End Get
        Set
            SetValue(ItemTemplateProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ItemTemplateProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemTemplate),
                           GetType(DataTemplate), GetType(ItemsControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ItemsControl)
                                                Dim old = DirectCast(oldValue, DataTemplate)
                                                Dim newVal = DirectCast(newValue, DataTemplate)
                                                If old IsNot newVal Then
                                                    this.OnItemTemplateChanged(old, newVal)
                                                End If
                                            End Sub)

    Protected Overridable Sub OnItemTemplateChanged(oldValue As DataTemplate, newValue As DataTemplate)

    End Sub

    Public Property ItemTemplateSelector As DataTemplateSelector
        Get
            Return GetValue(ItemTemplateSelectorProperty)
        End Get
        Set
            SetValue(ItemTemplateSelectorProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly ItemTemplateSelectorProperty As BindableProperty =
                           BindableProperty.Create(NameOf(ItemTemplateSelector),
                           GetType(DataTemplateSelector), GetType(ItemsControl),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, ItemsControl)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.OnItemTemplateSelectorChanged(old, newVal)
                                                End If
                                            End Sub)

    Protected Overridable Sub OnItemTemplateSelectorChanged(oldValue As DataTemplateSelector, newValue As DataTemplateSelector)

    End Sub

    Private Sub OnItemsChanged(oldValue As IEnumerable, newValue As IEnumerable)
        Dim parentView As View = ItemsContainer
        Dim itemsContainerAlive = False
        Do Until parentView Is Nothing
            If Content Is parentView Then
                itemsContainerAlive = True
                Exit Do
            Else
                parentView = parentView.Parent
            End If
        Loop
        If Not itemsContainerAlive Then
            Return
        End If
        Dim oldObservableCollection = TryCast(oldValue, INotifyCollectionChanged)
        If oldObservableCollection IsNot Nothing Then
            RemoveHandler oldObservableCollection.CollectionChanged, AddressOf OnItemsSourceCollectionChanged
        End If

        Dim newObservableCollection = TryCast(newValue, INotifyCollectionChanged)
        If newObservableCollection IsNot Nothing Then
            AddHandler newObservableCollection.CollectionChanged, AddressOf OnItemsSourceCollectionChanged
        End If

        If newValue IsNot Nothing Then
            ResetChildren(newValue)
        End If

        UpdateChildrenLayout()
        InvalidateLayout()
    End Sub

    Protected Overridable Sub OnItemsSourceChanged(oldValue As IEnumerable, newValue As IEnumerable)

    End Sub

    Private Sub ResetChildren(newValue As IEnumerable)
        ItemsContainer.Children.Clear()
        If newValue IsNot Nothing Then
            For Each item In newValue
                Dim view = CView(item, Me, ItemTemplate, ItemTemplateSelector)
                ItemsContainer.Children.Add(view)
            Next
        End If
    End Sub

    Private Sub OnItemsSourceCollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
        Dim invalidate = False
        Select Case e.Action
            Case NotifyCollectionChangedAction.Add
                If e.NewItems IsNot Nothing Then
                    For i = 0 To e.NewItems.Count - 1
                        Dim item = e.NewItems(i)
                        Dim view = CView(item, Me, ItemTemplate, ItemTemplateSelector)
                        ItemsContainer.Children.Insert(i + e.NewStartingIndex, view)
                    Next
                    invalidate = True
                End If
            Case NotifyCollectionChangedAction.Move
                Dim moveFrom = e.OldStartingIndex
                Dim moveTo = e.NewStartingIndex
                Dim oldView = Children(moveFrom)
                ItemsContainer.Children.RemoveAt(moveFrom)
                ItemsContainer.Children.Insert(moveTo, oldView)
                invalidate = True
            Case NotifyCollectionChangedAction.Remove
                If e.OldItems IsNot Nothing Then
                    ItemsContainer.Children.RemoveAt(e.OldStartingIndex)
                    For i = e.OldStartingIndex To e.OldStartingIndex + e.OldItems.Count - 2
                        ItemsContainer.Children.RemoveAt(i)
                    Next
                    invalidate = True
                End If
            Case NotifyCollectionChangedAction.Replace
                For i = 0 To e.OldItems.Count - 1
                    ItemsContainer.Children(i + e.OldStartingIndex) = CView(e.NewItems(i), Me, ItemTemplate, ItemTemplateSelector)
                Next
            Case NotifyCollectionChangedAction.Reset
                ResetChildren(e.NewItems)
                invalidate = True
        End Select

        If invalidate Then
            UpdateChildrenLayout()
            InvalidateLayout()
        End If
    End Sub

End Class
