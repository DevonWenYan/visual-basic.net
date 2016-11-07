Module Module1

    Sub Main()
        Dim myvar1 As Double = 801234567    '輸出結果：(080)123-4567	
        Console.WriteLine("1. " + myvar1.ToString("(0##) ###-####"))
        Dim myvar2 As Integer = -12345         '輸出結果：-12345
        Console.WriteLine("2. " + myvar2.ToString("######"))
        Dim myvar3 As Integer = -12345   '輸出結果：-012345
        Console.WriteLine("3. " + myvar3.ToString("000000"))
        Dim myvar4 As Double = -2.455    '輸出結果：-2.46
        Console.WriteLine("4. " + myvar4.ToString("#.##"))
        Dim myvar5 As Double = -2.4      '輸出結果：-2.40
        Console.WriteLine("5. " + myvar5.ToString("0.00"))
        Dim myvar6 As Double = -2.455   ' 輸出結果：-02.46
        Console.WriteLine("6. " + myvar6.ToString("00.00"))
        Dim myvar7 As Double = 1234567890   '輸出結果：1,234,567,890
        Console.WriteLine("7. " + myvar7.ToString("#,#"))
        Dim myvar8 As Double = 1234567890    ' 輸出結果：1234568
        Console.WriteLine("8. " + myvar8.ToString("#,"))
        Dim myvar9 As Double = 1234567890  '輸出結果： 1235
        Console.WriteLine("9. " + myvar9.ToString("#,,"))
        Dim myvar10 As Double = 1234567890  ' 輸出結果：1
        Console.WriteLine("10. " + myvar10.ToString("#,,,"))
        Dim myvar11 As Double = 1234567890   ' 輸出結果：1,235
        Console.WriteLine("11. " + myvar11.ToString("#,##0,,"))
        Dim myvar12 As Double = 0.086      ' 輸出結果：8.6%
        Console.WriteLine("12. " + myvar12.ToString("#0.##%"))
        Dim myvar13 As Double = 0.08647   '輸出結果：8.65%
        Console.WriteLine("13. " + myvar13.ToString("#0.##%"))
        Dim myvar14 As Double = 16800   '輸出結果：1.68E+4
        Console.WriteLine("14. " + myvar14.ToString("0.###E+0"))
        Dim myvar15 As Double = 16800  '輸出結果：1.68E+004
        Console.WriteLine("15. " + myvar15.ToString("0.###E+000"))
        Dim myvar16 As Double = 16800  '輸出結果：1.68E004
        Console.WriteLine("16. " + myvar16.ToString("0.###E-000"))
        Dim myvar17 As Double = 123456   '輸出結果：[12-34-56]
        Console.WriteLine("17. " + myvar17.ToString("[##-##-##]"))
        Dim myvar18 As Integer = 1234  '輸出結果：1234
        Console.WriteLine("18. " + myvar18.ToString("##;(##)"))
        Dim myvar19 As Integer = 1234    '輸出結果：(1234)
        Console.WriteLine("19. " + myvar19.ToString("(##);##"))
        Dim myvar20 As Integer = -1234     '輸出結果：(1234)
        Console.WriteLine("20. " + myvar20.ToString("##;(##)"))
        Console.Read()

    End Sub

End Module
