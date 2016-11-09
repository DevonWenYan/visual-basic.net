Module Module1

    Sub Main()
        Dim n, sum, i As Integer
        Console.WriteLine(" =求 1 到 100 可以被 n 整除的整數=")
        Console.WriteLine()
        Console.Write(" 請輸入 1 到 100 的整數 n：")
        n = Console.ReadLine
        If n >= 1 And n <= 100 Then
            Do While sum + n <= 100
                sum += n
                Console.Write(" {0},", sum)
                i += 1
                If i Mod 5 = 0 Then
                    Console.WriteLine()
                End If
            Loop
            Console.WriteLine()
            Console.WriteLine(" 由 1 到 100 有 {0} 個整數可以被 {1} 整除 ! ", i, n)
        Else
            Console.WriteLine("輸入的資料錯誤!")
        End If
        Console.ReadLine()
    End Sub

End Module
