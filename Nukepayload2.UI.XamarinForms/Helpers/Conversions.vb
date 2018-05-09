Friend Module Conversions
    ''' <summary>
    ''' 将指定的对象转换为 <see cref="View"/> 类型。
    ''' </summary>
    ''' <param name="obj">要转换的对象。</param>
    ''' <param name="parent">转换后的视图将被存放的容器控件。</param>
    ''' <param name="itemTemplate">如果要转换的对象不是 <see cref="View"/>, 指定模板产生视图以包装它。</param>
    ''' <param name="itemTemplateSelector">如果要转换的对象不是 <see cref="View"/>, 指定模板选择器产生视图以包装它。</param>
    ''' <exception cref="InvalidCastException"/>
    Function CView(obj As Object,
                   Optional parent As BindableObject = Nothing,
                   Optional itemTemplate As DataTemplate = Nothing,
                   Optional itemTemplateSelector As DataTemplateSelector = Nothing) As View
        If obj Is Nothing Then
            Return Nothing
        End If
        If TypeOf obj Is View Then
            Return obj
        End If
        If itemTemplateSelector IsNot Nothing AndAlso itemTemplate IsNot Nothing Then
            Throw New InvalidCastException($"{NameOf(itemTemplateSelector)} 不为空时，{NameOf(itemTemplate)} 无效。")
        End If
        Dim template As DataTemplate
        template = If(itemTemplateSelector?.SelectTemplate(obj, parent), itemTemplate)
        If template Is Nothing Then
            Return New ContentView With {
                .Content = obj
            }
        Else
            template.SetValue(BindableObject.BindingContextProperty, obj)
            Return TryCast(template.CreateContent, View)
        End If
    End Function
End Module
