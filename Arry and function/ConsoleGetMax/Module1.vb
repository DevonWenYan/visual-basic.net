Module Module1
    ' 以陣列當引數傳遞為參考呼叫
    Function GetMax(ByRef ary() As Integer) As Integer
        Dim max As Integer
        max = ary(0)              ' 先假設陣列第一個元素為最大值
        ' 使用 迴圈逐一尋找陣列元素中的最大值
        For i As Integer = 1 To ary.GetUpperBound(0)
            If max < ary(i) Then
                max = ary(i)
            End If
        Next
        Return max  ' 傳回陣列元素中的最大值
    End Function

    Sub Main()
        Dim tAry() As Integer = {12, 15, 38, 21, 25}
        Console.WriteLine("=陣列元素如下=")
        For i As Integer = 0 To tAry.GetUpperBound(0)
            Console.Write("{0} ", tAry(i))
        Next
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("陣列最大值：{0}", GetMax(tAry).ToString())
        Console.Read()
    End Sub

End Module
