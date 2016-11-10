Module Module1
    Sub Main()
        Console.WriteLine("t1模組中n ={0}", n)
        If n > 10 Then
            Dim n As Integer = 3
            Console.WriteLine(" 區塊中n={0}", n)
        End If
        Console.WriteLine("t1模組中n ={0}", n)
        Console.ReadLine()
    End Sub
End Module

Module t1
    Public n As Integer = 200
End Module
