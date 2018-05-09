Imports Nukepayload2.UI.Platform

<PlatformImpl(GetType(IApplication2))>
Friend Class AndroidApplicationExtension
    Implements IApplication2

    Public Sub Shutdown() Implements IApplication2.Shutdown
        Java.Lang.JavaSystem.Exit(0)
    End Sub
End Class
