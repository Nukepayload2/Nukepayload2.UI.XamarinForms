Imports System.Runtime.CompilerServices

Module EnumerableExtensions
    <Extension>
    Iterator Function ConcatAll(Of T)(source As IEnumerable(Of IEnumerable(Of T))) As IEnumerable(Of T)
        For Each src In source
            For Each src2 In src
                Yield src2
            Next
        Next
    End Function
    <Extension>
    Iterator Function ConcatInsert(Of T)(source As IEnumerable(Of IEnumerable(Of T)), insert As Func(Of IEnumerable(Of T), T)) As IEnumerable(Of T)
        For Each src In source
            For Each src2 In src
                Yield src2
            Next
            Yield insert(src)
        Next
    End Function
End Module
