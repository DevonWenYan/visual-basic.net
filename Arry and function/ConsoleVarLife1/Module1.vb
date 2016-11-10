Module Module1
    Dim n As Integer = 100
    Sub Main()
        Console.WriteLine("1. 模組中 取全域變數 n  = " & n)
        If n > 10 Then
            Dim n As Integer = 3
            Console.WriteLine("2. If 區塊內 取區域變數 n = " & n)
        End If
        Console.WriteLine("3. 離開區塊後 取全域變數 n =  " & n)
        Console.ReadLine()
    End Sub
End Module
