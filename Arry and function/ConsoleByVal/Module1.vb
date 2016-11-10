Module Module1

    Sub Main()
        Console.WriteLine()
        Console.WriteLine(" ======   Call By Vaule   ======")
        Dim a, b As Integer
        a = 10
        b = 12
        Console.WriteLine()
        Console.WriteLine("1.主程式未呼叫CallValue()程序前    : a={0}  b={1}", a, b)
        CallValue(a, b)
        Console.WriteLine()
        Console.WriteLine("2.離開CallValue()程序,回原呼叫處時 : a={0}  b={1}", a, b)
        Console.Read()
    End Sub

    Sub CallValue(ByVal x As Integer, ByVal y As Integer)   '傳值呼叫
        Dim z As Integer
        Console.WriteLine()
        Console.WriteLine("   CallValue()程序內 交換前        : x={0}  y={1}", x, y)
        z = x       ' 透過第三個變數來做x, y值互換
        x = y
        y = z
        Console.WriteLine()
        Console.WriteLine("   CallValue()程序內 交換後        : x={0}  y={1}", x, y)
    End Sub

End Module
