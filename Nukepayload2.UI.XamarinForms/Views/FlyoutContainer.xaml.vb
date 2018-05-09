Imports Nukepayload2.UI.Xaml.Services

Public Class FlyoutContainer
    Inherits ContentView

    Private _flyout As FlyoutBase

    Protected Friend Sub PutFlyout(newValue As FlyoutBase)
        If newValue IsNot Nothing Then
            If newValue IsNot _flyout Then
                If _flyout IsNot Nothing Then
                    GrdRoot.Children.Remove(_flyout)
                End If
                GrdRoot.Children.Add(newValue)
            End If
            IsVisible = True
            _flyout = newValue
        Else
            IsVisible = False
        End If
    End Sub

    Private Sub BackgroundInputWithEvents_Tapped(sender As Object, e As EventArgs) Handles BackgroundInputWithEvents.Tapped
        If _flyout IsNot Nothing AndAlso Not _flyout.IsModal Then
            _flyout.Hide()
        End If
    End Sub

    Private Sub OnComponentInitialized()
        _lastInstance = New WeakReference(Of FlyoutContainer)(Me)
        IsVisible = False
    End Sub

    Public Property Flyout As FlyoutBase
        Get
            Return GetValue(FlyoutProperty)
        End Get
        Set
            SetValue(FlyoutProperty, Value)
        End Set
    End Property
    Public Shared ReadOnly FlyoutProperty As BindableProperty =
                           BindableProperty.Create(NameOf(Flyout),
                           GetType(FlyoutBase), GetType(FlyoutContainer),
                           Nothing,
                           propertyChanged:=Sub(bindable, oldValue, newValue)
                                                Dim this = DirectCast(bindable, FlyoutContainer)
                                                Dim old = DirectCast(oldValue, FlyoutBase)
                                                Dim newVal = DirectCast(newValue, FlyoutBase)
                                                If old IsNot newVal Then
                                                    this.PutFlyout(newVal)
                                                End If
                                            End Sub)

    Private Shared _lastInstance As WeakReference(Of FlyoutContainer)
    ''' <summary>
    ''' 未在使用 NavigationService 时，获取最近一次仍然在被使用的实例。如果那个实例由于没有被使用而被 GC 回收，将会返回空。这适合单页的情况。
    ''' 如果在使用 NavigationService 并且当前页是内容页, 则在其中寻找第一个容器。这适合导航页内部导航内容页的情况。
    ''' </summary>
    Public Shared ReadOnly Property LastInstance As FlyoutContainer
        Get
            Dim curPage = TryCast(NavigationService.CurrentPage, ContentPage)
            If curPage Is Nothing Then
                Dim instance As FlyoutContainer = Nothing
                _lastInstance?.TryGetTarget(instance)
                Return instance
            Else
                Return FindInView(curPage.Content)
            End If
        End Get
    End Property

    Public Shared Function FindInView(root As View) As FlyoutContainer
        If root Is Nothing Then
            Return Nothing
        End If
        If TypeOf root Is FlyoutContainer Then
            Return root
        End If
        If TypeOf root Is Layout(Of View) Then
            Dim children As IList(Of View) = DirectCast(root, Layout(Of View)).Children
            For Each ele In children
                Dim eleInner = FindInView(ele)
                If eleInner IsNot Nothing Then
                    Return eleInner
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
