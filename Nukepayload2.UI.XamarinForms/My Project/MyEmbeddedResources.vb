Imports System.IO
Imports System.Reflection

Namespace My
    ''' <summary>
    ''' 提供对内嵌资源的访问。
    ''' </summary>
    Public Class EmbeddedResources
        Private Shared s_currentAssembly As Assembly = Assembly.GetExecutingAssembly
        Public Shared ReadOnly Property Assets(assetName As String) As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream($"Nukepayload2.UI.Xaml.{assetName}")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\BeginCheck.png
        ''' </summary>
        Public Shared ReadOnly Property BeginCheck As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.BeginCheck.png")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\ChangeLocation.png
        ''' </summary>
        Public Shared ReadOnly Property ChangeLocation As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.ChangeLocation.png")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\CloseConference.png
        ''' </summary>
        Public Shared ReadOnly Property CloseConference As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.CloseConference.png")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\ConferenceAction.png
        ''' </summary>
        Public Shared ReadOnly Property ConferenceAction As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.ConferenceAction.png")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\Dinner.png
        ''' </summary>
        Public Shared ReadOnly Property Dinner As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.Dinner.png")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\EndCheck.png
        ''' </summary>
        Public Shared ReadOnly Property EndCheck As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.EndCheck.png")
            End Get
        End Property

    End Class
End Namespace

