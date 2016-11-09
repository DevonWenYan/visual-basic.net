Module Module1

    Sub Main()
        Dim n1, n2, n3, max As Integer
        Console.Write("1. 請輸入第一個數值 : ")
        n1 = Integer.Parse(Console.ReadLine())
        Console.Write("2. 請輸入第二個數值 : ")
        n2 = Integer.Parse(Console.ReadLine())
        Console.Write("3. 請輸入第三個數值 : ")
        n3 = Integer.Parse(Console.ReadLine())
        If (n1 > n2) Then
            If (n1 > n3) Then
                max = n1
            Else
                max = n3
            End If
        Else
            If (n2 > n3) Then
                max = n2
            Else
                max = n3
            End If
        End If
        Console.WriteLine()
        Console.WriteLine("=== {0},{1},{2} 三數中最大值為 : {3} ", n1, n2, n3, max)
        Console.Read()

    End Sub

End Module
