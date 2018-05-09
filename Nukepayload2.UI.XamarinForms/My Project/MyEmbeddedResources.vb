Imports System.IO
Imports System.Reflection

Namespace My
    ''' <summary>
    ''' �ṩ����Ƕ��Դ�ķ��ʡ�
    ''' </summary>
    Public Class EmbeddedResources
        Private Shared s_currentAssembly As Assembly = Assembly.GetExecutingAssembly
        Public Shared ReadOnly Property Assets(assetName As String) As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream($"Nukepayload2.UI.Xaml.{assetName}")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\BeginCheck.png
        ''' </summary>
        Public Shared ReadOnly Property BeginCheck As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.BeginCheck.png")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\ChangeLocation.png
        ''' </summary>
        Public Shared ReadOnly Property ChangeLocation As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.ChangeLocation.png")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\CloseConference.png
        ''' </summary>
        Public Shared ReadOnly Property CloseConference As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.CloseConference.png")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\ConferenceAction.png
        ''' </summary>
        Public Shared ReadOnly Property ConferenceAction As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.ConferenceAction.png")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\Dinner.png
        ''' </summary>
        Public Shared ReadOnly Property Dinner As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.Dinner.png")
            End Get
        End Property

        ''' <summary>
        ''' ������Դ Assets\EndCheck.png
        ''' </summary>
        Public Shared ReadOnly Property EndCheck As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("Nukepayload2.UI.Xaml.EndCheck.png")
            End Get
        End Property

    End Class
End Namespace

