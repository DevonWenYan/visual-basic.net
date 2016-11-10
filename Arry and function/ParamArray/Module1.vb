Module Module1

    Sub Main()
        Console.WriteLine("1 ,5, 3 中最大數是 {0}", GetMax(1, 5, 3).ToString())
        Console.WriteLine()
        Console.WriteLine("10, 5, 3, 100, 23中最大數是 {0}", GetMax(10, 5, 3, 100, 23).ToString())
        Console.Read()
    End Sub

    Function GetMax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer
        max = x(0)
        For i As Integer = 1 To x.Length - 1
            If x(i) > max Then
                max = x(i)
            End If
        Next
        Return max
    End Function

End Module
