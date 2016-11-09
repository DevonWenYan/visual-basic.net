Module Module1

    Sub Main()
        Dim pwd As String = "" ' 宣告pwd密碼變數為字串型別
        Dim count As Integer = 0     ' 宣告count變數為整數型別，用來記錄輸入密碼次數
        ' For 迴圈初值count=1, 每次執行迴圈主體後count會加1
        ' 若count 大於等於3時，即會離開For迴圈，因此下列For 會執行3次
        For count = 1 To 3
            Console.Write("請輸入密碼(四個字元):")
            ' 使用者由鍵盤輸入密碼後，將密碼指定給pwd變數
            pwd = Console.ReadLine()
            If pwd = "ymca" Then     ' 判斷pwd密碼是否等於 "ymca"
                Exit For                        ' 離開 for 迴圈
            Else                                 ' 若pwd密碼不等於 "pwd" 則執行下列敘述
                Console.WriteLine("密碼錯誤 , 無法進入!")
            End If
            Console.WriteLine()
        Next
        If pwd = "ymca" Then      ' 判斷pwd密碼是否等於 "ymac"
            ' 密碼正確執行此敘述
            Console.WriteLine("登入成功 , 歡迎進入本系統…")
        Else
            ' 密碼不正確執行此敘述
            Console.WriteLine("非法進入...!")
        End If
        Console.Read()
    End Sub

End Module
