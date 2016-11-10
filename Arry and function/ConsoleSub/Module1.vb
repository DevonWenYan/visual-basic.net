Module Module1
    ' 定義Sub程序Login
    ' 呼叫Login程序時，第一個參數需傳入字串資料，第二個參數需傳入布林資料
    Sub Login(ByVal username As String, ByVal ismale As Boolean)
        Console.Write(username)
        If ismale Then
            Console.WriteLine("先生，歡迎光臨！")
        Else
            Console.WriteLine("小姐，歡迎光臨！")
        End If
    End Sub

    Sub Main()
        Dim name As String = "王小華"
        ' 呼叫Login程序
        ' 傳入的第一個參數為name變數，第二個參數為True
        Call Login(name, True)
        Console.WriteLine()
        ' 呼叫Login程序，傳入第一個參數是字串資料，第二個參數為False
        Login("李美美", False)
        Console.Read()
    End Sub

End Module
