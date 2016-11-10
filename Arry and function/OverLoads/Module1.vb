Module Module1

    Sub Main()
        Console.WriteLine("sum(1,2)={0}", sum(1, 2).ToString())
        Console.WriteLine("sum(1,2,3)={0}", sum(1, 2, 3).ToString())
        Console.WriteLine("sum(""a"", ""b"")={0}", sum("a", "b"))
        Console.WriteLine("sum(""a"", ""b"", ""c"")={0}", sum("a", "b", "c"))
        Console.ReadLine()
    End Sub
    ' 傳回兩數相加結果
    Function sum(ByVal x As Single, ByVal y As Single) As Single
        Return (x + y)
    End Function
    ' 傳回三數相加結果
    Function sum(ByVal x As Single, ByVal y As Single, ByVal z As Single) As Single
        Return (x + y + z)
    End Function
    ' 傳回兩個字串合併結果
    Function sum(ByVal x As String, ByVal y As String) As String
        Return (x & y)
    End Function
    ' 傳回三個字串合併結果
    Function sum(ByVal x As String, ByVal y As String, ByVal z As String) As String
        Return (x & y & z)
    End Function

End Module
