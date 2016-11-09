Module Module1

    Sub Main()
        Dim sum, n As Integer
        sum = 0
        n = 0
        Console.Write(" 請輸入 1+2+...+n<=sum, sum值：")
        Dim input As Integer = Val(Console.ReadLine())
        Do
            n += 1
            If sum <= input Then  '判斷sum是否小於等於輸入的上限值input
                sum += n
                Continue Do         '跳到Loop While 處判斷n是否大於0
            Else
                sum -= n - 1
                Exit Do         '離開迴圈
            End If
        Loop While n > 0
        Console.WriteLine(vbNewLine & " 結果 : 1+2...+{0} 等於 {1}", n - 2, _
                          sum.ToString())
        Console.Read()
    End Sub

End Module
