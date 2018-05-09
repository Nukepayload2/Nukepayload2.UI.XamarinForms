
Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(IApplication2))>
Friend Class UwpApplicationExtension
    Implements IApplication2

    Public Sub Shutdown() Implements IApplication2.Shutdown
        Application.Current.Exit()
    End Sub
End Class

