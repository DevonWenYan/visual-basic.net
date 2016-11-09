Module Module1

    Sub Main()
        Dim str As String
        Dim num, factorial As Integer
        factorial = 1
        Do
            Console.Write("請輸入階層數(正整數):")
            num = Val(Console.ReadLine()) ' 使用者輸入數值再指定給num
        Loop Until (num >= 1)       ' 當num沒有大於等於1則進入迴圈
        str = num.ToString()
        Do Until (num < 1)              '計算num階層
            factorial *= num
            num -= 1
        Loop
        Console.WriteLine("{0}! = {1}", str.ToString(), factorial.ToString())
        Console.ReadLine()
    End Sub

End Module
