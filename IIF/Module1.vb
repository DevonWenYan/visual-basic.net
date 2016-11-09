Module Module1

    Sub Main()
        ' 宣告income所得變數、tax稅金變數、taxRate稅率變數為浮點數型別
        Dim income, tax, taxRate As Double
        Console.Write("請輸入個人年度所得 (單位:萬元)：")
        ' 使用者由鍵盤輸入資料再透過Val方法轉成浮點數資料
        ' 接著再指定給income變數
        income = Val(Console.ReadLine())
        ' 若income 小於 100則 taxRate等於0.15
        ' 若income 介於 100~200則 taxRate等於0.2
        ' 若income 大於 200則 taxRate等於0.4
        taxRate = IIf(income < 100, 0.15, IIf(income < 200, 0.2, 0.4))
        tax = income * taxRate * 10000  ' income所得*taxRate稅率求tax稅金
        Console.WriteLine("你的稅率為:{0}%", (taxRate * 100).ToString())   ' 顯示稅率
        Console.WriteLine("你應付的稅金為:{0}元", tax.ToString())      ' 顯示稅金
        Console.Read()
    End Sub

End Module
