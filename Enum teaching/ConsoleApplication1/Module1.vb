Module Module1
    Enum State : int
        Binary = 2
        Octal = 8
        Hex = 16
    End Enum

    Sub Main()
        Console.WriteLine("二進位的常數值是{0}", CType(State.Binary, Integer))
        Console.WriteLine("八進位的常數值是{0}", CType(State.Octal, Integer))
        Console.WriteLine("十六進位的常數值是{0}", CType(State.Hex, Integer))
        Console.Read()

    End Sub

End Module
