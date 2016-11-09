Module Module1

    Sub Main()
        Console.WriteLine("試問Visual Studio 可開發下列哪種應用程式")
        Console.WriteLine()
        Console.WriteLine("1.視窗程式   2.Web 程式   3.裝置應用程式   4. 以上皆可")
        Console.WriteLine()
        Console.Write(" 請作答：")

        ' 宣告Ans字串變數用來存放使用者由鍵盤輸入的答案
        Dim Ans As String = Console.ReadLine()
        Console.WriteLine()
        ' 判斷Ans是否為1, 2, 3其中之一
        If (Ans = "1" Or Ans = "2" Or Ans = "3") Then
            Console.WriteLine(" === 答錯了, 正確答案是 4 .")
        ElseIf (Ans = "4") Then   ' 判斷Ans是否等於4
            Console.WriteLine(" === 答對了, 真不愧是 .NET 達人....")
        Else                  ' 當Ans不等於1 ,2 ,3, 4時執行下列敘述
            Console.WriteLine(" === 無此選項....")
        End If
        Console.Read()
    End Sub

End Module
