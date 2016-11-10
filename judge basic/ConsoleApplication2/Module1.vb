Module Module1

    Sub Main()
        Dim key As Integer
        Dim str As String
        Console.WriteLine("請輸入卡號")
        key = Console.ReadLine()
        Select Case key
            Case 3
                str = "聯合信用卡"
            Case 35
                str = "JCB信用卡"
            Case 45, 46
                str = "VISA信用卡"
            Case 54, 55
                str = "MASTER用卡"
            Case Else
                str = "非商業的信用卡"
        End Select
        Console.WriteLine("你的卡號為{0}，屬於{1}", key, str)
        Console.Read()
        Console.Read()


    End Sub

End Module
