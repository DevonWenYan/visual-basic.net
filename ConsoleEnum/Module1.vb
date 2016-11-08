Module Module1

    ' 定義WeekDays列舉內容有7個成員
    ' 用來表示一星期的星期一到星期日的列舉常數值
    Enum WeekDays : int
        Monday = 1             ' 星期一
        Tuesday = 2            ' 星期二
        Wednesday = 3         ' 星期三
        Thursday = 4          ' 星期四
        Friday = 5            ' 星期五
        Saturday = 6          ' 星期六
        Sunday = 7            ' 星期日
    End Enum

    Sub Main()
        ' 使用CType函式將WeekDays.Wednesday列舉常數值轉成整數
        Console.WriteLine("星期三列舉常數值：{0}", CType(WeekDays.Wednesday, Integer))
        Console.WriteLine("星期五列舉常數值：{0}", CType(WeekDays.Friday, Integer))
        Console.Read()
    End Sub

End Module
