Namespace Services
    ''' <summary>
    ''' 控制应用程序的导航
    ''' </summary>
    Public Class NavigationService
        ''' <summary>
        ''' 用于导航的框架
        ''' </summary>
        Public Shared ReadOnly Property Frame As NavigationPage

        ''' <summary>
        ''' 将导航服务连接到导航框架中。
        ''' </summary>
        ''' <param name="frame">导航用的框架</param>
        Public Shared Sub Connect(frame As NavigationPage)
            _Frame = frame
        End Sub

        Private Shared s_navigationCache As New NavigationCache

        ''' <summary>
        ''' 导航到新的页
        ''' </summary>
        ''' <param name="pageType">导航到哪种页面</param>
        ''' <exception cref="ArgumentException"/>
        Public Shared Async Function NavigateToAsync(pageType As Type) As Task
            If pageType Is Nothing Then
                Throw New ArgumentNullException(NameOf(pageType))
            End If
            If Not GetType(Page).IsAssignableFrom(pageType) Then
                Throw New ArgumentException($"{pageType} is not Page.", NameOf(pageType))
            End If
            Await NavigateToImplAsync(pageType)
        End Function

        ''' <summary>
        ''' 导航到新的页
        ''' </summary>
        ''' <typeparam name="TPage">导航到哪种页面</typeparam>
        Public Shared Async Function NavigateToAsync(Of TPage As Page)() As Task
            Dim pageType = GetType(TPage)
            Await NavigateToImplAsync(pageType)
        End Function

        Private Shared Async Function NavigateToImplAsync(pageType As Type) As Task
            Dim cached = s_navigationCache(pageType)
            If cached Is Nothing Then
                cached = DirectCast(Activator.CreateInstance(pageType), Page)
                s_navigationCache(pageType) = cached
            End If
            Dim clearNavigationStack = Not NavigationPage.GetHasBackButton(cached) AndAlso Frame.StackDepth > 0
            If clearNavigationStack Then
                Await Frame.PopToRootAsync()
            End If
            Await Frame.PushAsync(cached)
            'If clearNavigationStack Then
            '    Frame.Navigation.RemovePage(Frame.RootPage)
            'End If
        End Function

        ''' <summary>
        ''' 回退一页
        ''' </summary>
        Public Shared Async Function GoBackAsync() As Task(Of Page)
            Dim page = Frame.CurrentPage
            If page IsNot Nothing AndAlso NavigationPage.GetHasBackButton(page) Then
                Return Await Frame.PopAsync
            End If
            Return Nothing
        End Function

        Public Shared ReadOnly Property CurrentPage As Page
            Get
                Return Frame?.CurrentPage
            End Get
        End Property
    End Class

    Friend Class NavigationCache
        Private _instances As New Dictionary(Of Type, WeakReference(Of Page))
        Default Public Property Item(type As Type) As Page
            Get
                Dim pageRef As WeakReference(Of Page) = Nothing
                If _instances.TryGetValue(type, pageRef) Then
                    Dim pageInstance As Page = Nothing
                    If pageRef.TryGetTarget(pageInstance) Then
                        Return pageInstance
                    End If
                End If
                Return Nothing
            End Get
            Set(value As Page)
                If _instances.ContainsKey(type) Then
                    _instances(type) = New WeakReference(Of Page)(value)
                End If
                _instances.Add(type, New WeakReference(Of Page)(value))
            End Set
        End Property
    End Class
End Namespace