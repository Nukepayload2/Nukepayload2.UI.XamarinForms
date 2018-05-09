# 已知问题
## 时间线
### 项目删除后再添加导致控件重叠
Android 上的控件池没有清理取出的控件。使用过多实例 DataTemplate 反模式可绕过。但是带来虚拟化问题。
### 无法嵌套在 ScrollView
ScrollView 没有处理嵌套的情况。需要 Xamarin.Forms 处理。
