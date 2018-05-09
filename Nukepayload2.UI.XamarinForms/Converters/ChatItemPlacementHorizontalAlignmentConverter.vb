Imports System.Globalization

Public Class ChatItemPlacementHorizontalAlignmentConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return If(DirectCast(value, ChatItemPlacement) = ChatItemPlacement.Left, LayoutOptions.Start, LayoutOptions.End)
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
