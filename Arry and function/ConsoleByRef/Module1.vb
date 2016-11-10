Module Module1

    Sub Main()
        Console.WriteLine()
        Console.WriteLine(" ======  Call ByReference 參考呼叫     ======")
        Dim a, b As Integer
        a = 10
        b = 12
        Console.WriteLine()
        Console.WriteLine("1. 主程式 未進入CallRef()程序前 : a={0}  b={1}", a, b)
        CallRef(a, b)
        Console.WriteLine()
        Console.WriteLine("2. 離開CallRef()程序回原處時    : a={0}  b={1}", a, b)
        Console.Read()
    End Sub

    Sub CallRef(ByRef x As Integer, ByRef y As Integer)   '參考呼叫
        Dim z As Integer
        Console.WriteLine()
        Console.WriteLine("  CallRef()程序內 交換前        : x={0}  y={1}", x, y)
        z = x
        x = y
        y = z
        Console.WriteLine()
        Console.WriteLine("  CallRef()程序內 交換後        : x={0}  y={1}", x, y)
    End Sub

End Module
