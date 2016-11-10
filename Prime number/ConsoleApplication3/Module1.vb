Module Module1

    Sub Main()
        Dim num, i, j, count As Integer
        For i = 2 To 1000
            count = 0
            For j = 2 To i
                num = i Mod j
                If (num = 0) Then
                    count += 1
                End If
            Next
            If (count = 1) Then
                Console.Write("{0} ", i)
            End If
        Next
        Console.Read()
    End Sub

End Module
