Module Module1

    Sub Main()
        Dim RoleName() As String = {"魯夫", "喬巴", "羅賓", "香吉士", "騙人布"}
        Dim money() As Integer = {100000, 10000, 1000, 100, 10}
        Console.WriteLine("= =草帽海賊團的成員= =")
        Console.WriteLine()
        Console.WriteLine("姓名{0}選賞金額", vbTab)
        Console.WriteLine("= = == = = = = = = == = =")
        For i As Integer = 0 To RoleName.GetUpperBound(0)
            Console.WriteLine("{0}{1}{2}", RoleName(i), vbTab, money(i))
        Next
        Console.Read()

    End Sub

End Module
