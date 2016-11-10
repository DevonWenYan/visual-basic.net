Module Module1

    Class MyFirstClass     ' 定義類別，名稱為MyFirstClass

    End Class

    Sub Main()
        Console.WriteLine("建立一個 MyFirstClass 物件 A ...")
        Dim A As New MyFirstClass()

        ' 上述一行敘述也可以改成如下兩行
        ' Dim A As MyFirstClass   ' 宣告A物件為MyFirstClass類別
        ' A = New MyFirstClass()  ' 使用New敘述建立A物件為MyFirstClass類別

        Console.WriteLine("A 物件建立完成 !!")
        Console.WriteLine("請按 Enter 結束 ...")
        Console.Read()
    End Sub

End Module
