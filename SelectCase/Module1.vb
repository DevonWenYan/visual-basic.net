Module Module1

    Sub Main()
        ' 宣告BirthDayYear用來存放你的生日年份
        ' 宣告NowYear用來存放今年年份
        ' 宣告Age用來存放你的年齡
        Dim BirthDayYear, NowYear, Age As Integer, str As String
        Console.Write("請輸入你出生的年份(西元) : ")
        ' 由鍵盤輸入生日年份
        BirthDayYear = Console.ReadLine()
        ' Now函式可用來取得目前完整日期與時間
        ' 透過Year函式取出今年年份再指定NowYear變數
        NowYear = Year(Now)
        Age = NowYear - BirthDayYear ' 生日年份減掉今年即得到年齡Age
        Select Case Age         ' 判斷 age年齡落在那個Case
            Case Is < 14          '年齡小於14，執行下一敘述後，便跳出End Select
                str = "兒童"
            Case 14, 15, 16, 17 '年齡14-17，執行下一敘述後，便跳出End Select
                str = "青少年"
            Case 18 To 30        '年齡18-30，執行下一敘述後，便跳出End Select
                str = "青年"
            Case 31 To 45        '年齡31-45，執行下一敘述後，便跳出End Select
                str = "壯年"
            Case 46 To 60        '年齡46-60，執行下一敘述後，便跳出End Select
                str = "中年"
            Case Else             '年齡大於60，執行下一敘述後，便跳出End Select
                str = "老年"
        End Select
        Console.WriteLine("你的年齡 : {0} 歲, 是處於 {1} 時期", Age, str)
        Console.Read()
    End Sub

End Module
