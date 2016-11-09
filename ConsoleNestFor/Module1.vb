Module Module1

    Sub Main()
        Dim i, k As Integer   ' 宣告 i 為外層迴圈的初值，k 為內層迴圈的初值
        For i = 1 To 5           ' 外層迴圈
            For k = 1 To i      ' 內層迴圈
                Console.Write("  {0}", k.ToString())  ' 游標停在同一列     
            Next
            Console.WriteLine()        ' 強迫換列
        Next
        Console.Read()
    End Sub

End Module
