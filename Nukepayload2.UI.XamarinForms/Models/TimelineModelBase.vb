Imports Nukepayload2.UI.Xaml

Public MustInherit Class TimelineModelBase
    Implements ICloneable(Of TimelineModelBase)

    Public MustOverride Function Clone() As TimelineModelBase Implements ICloneable(Of TimelineModelBase).Clone
End Class
