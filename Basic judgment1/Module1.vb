Module Module1

    Sub Main()
        ' 宣告Pwd密碼及Uid帳號字串變數
        Dim Pwd, Uid As String
        Console.Write("請輸入帳號 :")
        Uid = Console.ReadLine()        ' 輸入的資料指定給Uid變數
        Console.Write("請輸入密碼 :")
        Pwd = Console.ReadLine()          ' 輸入的資料指定給Pwd變數
        Console.WriteLine()
        ' 判斷Uid是否等於 "gotop" 且 Pwd是否等於 "5168"
        If (Uid = "gotop" And Pwd = "5168") Then
            Console.WriteLine("Pass...")  ' 帳號密碼正確執行此敘述
        Else
            Console.WriteLine("Fail...")  ' 帳號密碼錯誤執行此敘述
        End If
        Console.Read()      ' 等待由鍵盤輸入資料，以方便觀看執行結果

    End Sub

End Module
