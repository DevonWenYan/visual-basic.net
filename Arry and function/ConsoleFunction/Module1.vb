Module Module1
    ' 定義GetWelcome函式，該函式傳回型別為String 字串
    Function GetWelcome(ByVal username As String, ByVal ismale As Boolean) As String
        If ismale Then
            GetWelcome = username & "先生，歡迎光臨！"
        Else
            GetWelcome = username & "小姐，歡迎光臨！"
        End If
    End Function

    Sub Main()
        Dim name As String = "王小華", welcome As String
        ' 將函式傳回的結果指定給Welcome變數
        welcome = GetWelcome(name, True)
        Console.WriteLine(welcome)
        Console.WriteLine()
        Console.WriteLine(GetWelcome("李美美", False))
        Console.Read()
    End Sub

End Module
