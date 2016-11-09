Module Module1

    Sub Main()
        ' 宣告yes字串變數用來存放使用者輸入的資料
        Dim yes As String = ""
        ' 宣告count整數變數，用來記錄進入迴圈的次數
        Dim count As Integer = 0
        Do
            count += 1   'count加1
            Console.WriteLine("第 {0} 次進入迴圈", count.ToString())
            Console.Write("是否繼續 (Y/N) ?")
            ' 將使用者由鍵盤輸入的資料放入yes變數
            yes = Console.ReadLine()
            Console.WriteLine()
        Loop While yes = "y" Or yes = "Y" '若yes變數等於"y"或"Y"則進入迴圈
        Console.WriteLine("已離開迴圈 ! ")
        Console.Read()
    End Sub

End Module
