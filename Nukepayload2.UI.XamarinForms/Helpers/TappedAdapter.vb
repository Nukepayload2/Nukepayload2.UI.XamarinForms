Imports System.Windows.Input

''' <summary>
''' 指定处理 <see cref="ListView.ItemTapped"/> 事件的命令和命令参数。注意: <see cref="ListView.SelectedItem"/> 属性需要 <see cref="BindingMode.TwoWay"/> 绑定。
''' </summary>
Public NotInheritable Class ItemTappedAdapter

    Public Shared Function GetCommandParameter(element As BindableObject) As Object
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        Return element.GetValue(CommandParameterProperty)
    End Function

    Public Shared Sub SetCommandParameter(element As BindableObject, value As Object)
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        element.SetValue(CommandParameterProperty, value)
    End Sub

    Public Shared ReadOnly CommandParameterProperty As _
                           BindableProperty = BindableProperty.CreateAttached("CommandParameter",
                           GetType(Object), GetType(ItemTappedAdapter),
                           Nothing)

    Public Shared Function GetCommand(element As BindableObject) As ICommand
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        Return element.GetValue(CommandProperty)
    End Function

    Public Shared Sub SetCommand(element As BindableObject, value As ICommand)
        If element Is Nothing Then
            Throw New ArgumentNullException(NameOf(element))
        End If

        element.SetValue(CommandProperty, value)
    End Sub

    ''' <summary>
    ''' 保留 Shared 方法中对于每一个 <see cref="ListView"/> 实例的闭包。在 Visual Basic 中, 闭包对于 Shared Sub New 中的匿名委托使用 Shared 字段存储。此时应该对于每一个 <see cref="ListView"/> 存储一个这样的闭包。
    ''' </summary>
    Private Class CommandPropertyChangedClosure
        Private Shared s_instances As New Dictionary(Of ListView, CommandPropertyChangedClosure)

        Public Shared Property Instance(lst As ListView) As CommandPropertyChangedClosure
            Get
                Dim value As CommandPropertyChangedClosure = Nothing
                s_instances.TryGetValue(lst, value)
                Return value
            End Get
            Set(value As CommandPropertyChangedClosure)
                If value Is Nothing Then
                    s_instances.Remove(lst)
                Else
                    s_instances(lst) = value
                End If
            End Set
        End Property

        Private list As ListView
        Private cmd As ICommand

        Public Sub Body(sender As Object, e As ItemTappedEventArgs)
            Dim cmdParam = GetCommandParameter(list)
            If cmd.CanExecute(cmdParam) Then
                cmd.Execute(cmdParam)
            End If
        End Sub

        Public Sub New(list As ListView, cmd As ICommand)
            Me.list = list
            Me.cmd = cmd
        End Sub
    End Class

    Public Shared ReadOnly CommandProperty As _
        BindableProperty = BindableProperty.CreateAttached("Command",
        GetType(ICommand), GetType(ItemTappedAdapter),
        Nothing, propertyChanged:=
        Sub(sender, oldValue, newValue)
            Dim lst = TryCast(sender, ListView)
            If lst Is Nothing Then
                Throw New ArgumentException("必须在 ListView 控件使用。", NameOf(sender))
            End If
            If newValue IsNot Nothing Then
                Dim cmd = DirectCast(newValue, ICommand)
                Dim closure = CommandPropertyChangedClosure.Instance(lst)
                If closure IsNot Nothing Then
                    RemoveHandler lst.ItemTapped, AddressOf closure.Body
                End If
                closure = New CommandPropertyChangedClosure(lst, cmd)
                AddHandler lst.ItemTapped, AddressOf closure.Body
                CommandPropertyChangedClosure.Instance(lst) = closure
            Else
                CommandPropertyChangedClosure.Instance(lst) = Nothing
            End If
        End Sub)

End Class
