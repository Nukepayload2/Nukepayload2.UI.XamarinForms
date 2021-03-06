﻿Imports System.Reflection

Namespace Global.Nukepayload2.UI.Platform
    ''' <summary>
    ''' 注册平台实现相关内容。详细解释见 N2Engine 文档。
    ''' </summary>
    Public Class PlatformImplRegistration
        Implements IDisposable

        ''' <summary>
        ''' 已经注册的 需要平台实现类型的类型(不是联系类型)-平台实现类型。例如，ExampleView与ExamplePresenter
        ''' </summary>
        Friend Shared ReadOnly Property Registered As New Dictionary(Of Type, Type)
        ''' <summary>
        ''' 注册好的平台。正常运行的情况下只需要注册一个平台。
        ''' </summary>
        Friend Shared ReadOnly Property Platforms As New List(Of String)
        ''' <summary>
        ''' 与平台实现类型关联的类型是否注册了
        ''' </summary>
        ''' <param name="tp">与平台实现类型关联的类型</param>
        Public Shared Function HasPCLTypeRegistered(tp As Type) As Boolean
            Return Registered.Keys.Contains(tp)
        End Function
        ''' <summary>
        ''' 平台实现类型是否注册了
        ''' </summary>
        ''' <param name="tp">平台实现类型</param>
        Public Shared Function HasPlatformTypeRegistered(tp As Type) As Boolean
            Return Registered.Values.Contains(tp)
        End Function
        ''' <summary>
        ''' 正在注册的平台
        ''' </summary>
        Dim curPlatform As String
        ''' <summary>
        ''' 创建一个平台的注册
        ''' </summary>
        Sub New(platform As String)
            If String.IsNullOrEmpty(platform) Then
                Throw New InvalidOperationException("必须指定一个平台")
            End If
            If Platforms.Contains(platform) Then
                Throw New InvalidOperationException("请不要重复注册平台实现")
            End If
            curPlatform = platform
        End Sub
        ''' <summary>
        ''' 注册需要注册的实现类型, 返回是否注册成功
        ''' </summary>
        ''' <param name="declType">视图的类型</param>
        ''' <param name="implType">渲染器的类型</param>
        ''' <returns>注册成功返回真。否则返回假。</returns>
        Public Function RegisterImplType(declType As Type, implType As Type) As Boolean
            Dim canReg = Not Registered.ContainsKey(declType)
            If canReg Then
                Registered.Add(declType, implType)
            Else
                Debug.WriteLine($"检测到注册重复。.NET Standard 类型 {declType.FullName}, 实现类型 {implType.FullName}。")
            End If
            Return canReg
        End Function
        ''' <summary>
        ''' 注册某个平台的特定实现。将注册带有 <see cref="PlatformImplAttribute"/> 的类。如果没有检测到重复注册则返回真。 
        ''' </summary>
        ''' <param name="pImplRegType">平台实现注册类型。它代表着平台实现的程序集。</param>
        Public Function RegsterApiContract(Of T)() As Boolean
            Return RegsterImplAssembly(GetType(T).Assembly)
        End Function
        ''' <summary>
        ''' 注册某个平台的特定实现。将注册带有 <see cref="PlatformImplAttribute"/> 的类。如果没有检测到重复注册则返回真。 
        ''' </summary>
        ''' <param name="pImplAsm">平台实现的程序集。</param>
        Public Function RegsterImplAssembly(pImplAsm As Assembly) As Boolean
            Return Aggregate tp In pImplAsm.DefinedTypes
                   Where tp.IsClass AndAlso tp.IsNotPublic
                   Let attr = tp.GetCustomAttributes(Of PlatformImplAttribute).FirstOrDefault
                   Where attr IsNot Nothing AndAlso Not tp.GetCustomAttributes(Of RegistrationIgnoreAttribute).Any
                   Select success = RegisterImplType(attr.DeclType, tp.AsType) Into All(success)
        End Function
        ''' <summary>
        ''' 结束此次平台注册。无论是否发生异常，平台都将登记。
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            Platforms.Add(curPlatform)
        End Sub
        ''' <summary>
        ''' 查询已经注册的平台
        ''' </summary>
        Public Shared Function GetRegisteredPlatforms() As IEnumerable(Of String)
            Return Platforms
        End Function
    End Class
End Namespace