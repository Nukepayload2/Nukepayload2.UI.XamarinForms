Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Globalization

Public Class TimelineIconTextConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return "ERROR"
        End If
        Dim type As Type = value.GetType
        Dim valueField As FieldInfo = type.GetField(value.ToString)
        Return valueField.GetCustomAttribute(Of DisplayAttribute).Name
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
