Imports System.Globalization
Imports System.Reflection

Public Class EnumItemsConverter
    Implements IValueConverter

    Private _cachedResults As New Dictionary(Of Type, [Enum]())

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return {}
        End If
        Dim members As [Enum]() = Nothing
        Dim tp = value.GetType
        If _cachedResults.TryGetValue(tp, members) Then
            Return members
        End If
        members = Aggregate f In tp.GetRuntimeFields
                  Where f.IsPublic AndAlso Not f.IsSpecialName AndAlso f.IsLiteral
                  Select DirectCast(f.GetValue(Nothing), [Enum]) Into ToArray
        _cachedResults.Add(tp, members)
        Return members
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
