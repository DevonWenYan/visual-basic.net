Module Module1

    Sub Main()
        ' 宣告Str變數用來存放信用卡的種類
        ' 宣告CardNo變數用來存放信用卡最前面兩個數字
        Dim Str, CardNo As String
        Console.Write("請輸入信用卡號碼最前面兩位數是 : ")
        CardNo = Console.ReadLine()
        Console.WriteLine()
        Str = Microsoft.VisualBasic.Switch(CardNo = 3, "聯合", CardNo = 35, "JCB", CardNo = 45 Or CardNo = 46, "VISA", CardNo = 54 Or CardNo = 55, "Master", CardNo <> 0 Or CardNo = 0, "非商業")
        Console.WriteLine("你是使用 {0} 信用卡", Str)
        Console.Read()  ' 藉等待由鍵盤輸入資料，以方便看執行結果
    End Sub

End Module
