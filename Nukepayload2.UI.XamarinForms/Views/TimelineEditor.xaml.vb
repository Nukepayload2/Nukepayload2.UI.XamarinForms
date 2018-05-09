Imports System.Windows.Input

Public Class TimelineEditor
    Inherits ContentView

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
                           GetType(String), GetType(TimelineEditor),
                           String.Empty,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, String)
                                                Dim newVal = DirectCast(newValue, String)
                                                If old IsNot newVal Then
                                                    this.LblHeader.Text = newVal
                                                End If
                                            End Sub)

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
                           GetType(IEnumerable), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, IEnumerable)
                                                Dim newVal = DirectCast(newValue, IEnumerable)
                                                If old IsNot newVal Then
                                                    this.LstItems.ItemsSource = newVal
                                                End If
                                            End Sub)

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
                           GetType(DataTemplateSelector), GetType(TimelineEditor),
                           New TimelineEditDataTemplateSelector,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, DataTemplateSelector)
                                                Dim newVal = DirectCast(newValue, DataTemplateSelector)
                                                If old IsNot newVal Then
                                                    this.LstItems.ItemTemplateSelector = newVal
                                                End If
                                            End Sub)

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
                           GetType(Object), GetType(TimelineEditor),
                           Nothing, defaultBindingMode:=BindingMode.TwoWay,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                If oldValue IsNot newValue Then
                                                    this.LstItems.SelectedItem = newValue
                                                End If
                                            End Sub)

    Public Property DeleteCommand As ICommand
        Get
            Return GetValue(DeleteCommandProperty)
        End Get
        Set
            SetValue(DeleteCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly DeleteCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(DeleteCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnDelete.Command = newVal
                                                End If
                                            End Sub)

    Public Property UndoCommand As ICommand
        Get
            Return GetValue(UndoCommandProperty)
        End Get
        Set
            SetValue(UndoCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly UndoCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(UndoCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnUndo.Command = newVal
                                                End If
                                            End Sub)

    Public Property RedoCommand As ICommand
        Get
            Return GetValue(RedoCommandProperty)
        End Get
        Set
            SetValue(RedoCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly RedoCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(RedoCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnRedo.Command = newVal
                                                End If
                                            End Sub)

    Public Property AddDateCommand As ICommand
        Get
            Return GetValue(AddDateCommandProperty)
        End Get
        Set
            SetValue(AddDateCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly AddDateCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(AddDateCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnAddDate.Command = newVal
                                                End If
                                            End Sub)

    Public Property AddTimeCommand As ICommand
        Get
            Return GetValue(AddTimeCommandProperty)
        End Get
        Set
            SetValue(AddTimeCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly AddTimeCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(AddTimeCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnAddTime.Command = newVal
                                                End If
                                            End Sub)

    Public Property AddActionCommand As ICommand
        Get
            Return GetValue(AddActionCommandProperty)
        End Get
        Set
            SetValue(AddActionCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly AddActionCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(AddActionCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnAddAction.Command = newVal
                                                End If
                                            End Sub)

    Public Property MoveDownCommand As ICommand
        Get
            Return GetValue(MoveDownCommandProperty)
        End Get
        Set
            SetValue(MoveDownCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly MoveDownCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(MoveDownCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnMoveDown.Command = newVal
                                                End If
                                            End Sub)

    Public Property MoveUpCommand As ICommand
        Get
            Return GetValue(MoveUpCommandProperty)
        End Get
        Set
            SetValue(MoveUpCommandProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly MoveUpCommandProperty As BindableProperty =
                           BindableProperty.Create(NameOf(MoveUpCommand),
                           GetType(ICommand), GetType(TimelineEditor),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, TimelineEditor)
                                                Dim old = DirectCast(oldValue, ICommand)
                                                Dim newVal = DirectCast(newValue, ICommand)
                                                If old IsNot newVal Then
                                                    this.BtnMoveUp.Command = newVal
                                                End If
                                            End Sub)

    Public Custom Event AddDateRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnAddDate.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnAddDate.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event AddTimeRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnAddTime.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnAddTime.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event AddActionRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnAddAction.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnAddAction.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event UndoRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnUndo.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnUndo.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event RedoRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnRedo.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnRedo.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event DeleteRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnDelete.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnDelete.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event MoveUpRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnMoveUp.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnMoveUp.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Public Custom Event MoveDownRequested As EventHandler
        AddHandler(value As EventHandler)
            AddHandler BtnMoveDown.Clicked, value
        End AddHandler
        RemoveHandler(value As EventHandler)
            RemoveHandler BtnMoveDown.Clicked, value
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
        End RaiseEvent
    End Event

    Private Sub LstItemsWithEvents_ItemSelected(sender As Object, e As SelectedItemChangedEventArgs) Handles LstItemsWithEvents.ItemSelected
        SelectedItem = e.SelectedItem
    End Sub

    Private Sub OnComponentInitialized()
        LstItems.ItemTemplateSelector = ItemTemplateSelector
    End Sub
End Class
