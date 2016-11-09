Module Module1

    Sub Main()
        ' 宣告Str字串變數用來存放信用卡的種類
        ' 宣告No字串變數用來存放使用者選擇的選項
        Dim Str, No As String
        Console.WriteLine("請問你的信用卡號碼最前面兩位數是 : ")
        Console.WriteLine(" 1. 03 開頭 ")
        Console.WriteLine(" 2. 35 開頭")
        Console.WriteLine(" 3. 45 或 46 開頭")
        Console.WriteLine(" 4. 54 或 55 開頭")
        Console.Write("請選擇 : ")
        No = Console.ReadLine()
        If No >= 1 And No <= 4 Then
            ' 若No為1-4之間則執行此敘述
            Str = Choose(No, "聯合", "JCB", "VISA", "Master")
        Else
            Str = "非商業"     ' 若No不在1-4之間則執行此敘述
        End If
        Console.WriteLine("你是使用 {0} 信用卡", Str)
        Console.Read()
    End Sub

End Module
