Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        Dim num3, num4 As Double
        num3 = 1234.567
        num4 = -1234.567
        Console.WriteLine("num3=1234.567   num4=-1234.567 的C/c3格式分別為:")
        Console.WriteLine("num3={0:C}   num4={1:c3} ", num3, num4)
        Console.WriteLine()

        num1 = 123456
        num2 = -123456
        Console.WriteLine()
        Console.WriteLine("num1=123456    num2=-123456 的 D9/d3/D格式分別為 :")
        Console.WriteLine("num1={0:D9}  num2={1:d3} num2={2:D}", num1, num2, num2)

        Console.WriteLine()
        Console.WriteLine("num3=1234.567   num4=-1234.567的E/e2格式分別為 :")
        Console.WriteLine("num3={0:E}    num4={1:e2}", num3, num4)
        Console.WriteLine()

        num3 = 1234.567
        num4 = -1234.567
        Console.WriteLine("num3=1234.567  num4=-1234.567 的 F1/f 格式分別為:")
        Console.WriteLine("num3={0:F1}   num4={1:f} ", num3, num4)
        Console.WriteLine()

        num3 = 1234.567
        num4 = -1234.567
        Console.WriteLine("num3=1234.567  num4=-1234.567的G3和g格式分別為 :")
        Console.WriteLine("num3={0:G3}   num4={1:g} ", num3, num4)
        Console.WriteLine()

        num3 = 1234.567
        num4 = -1234.567
        Console.WriteLine("num3=1234.567  num4=-1234.567 的 G/g4 格式分別為:")
        Console.WriteLine("num3={0:G}   num4={1:g4} ", num3, num4)
        Console.WriteLine()

        num3 = 1234.567
        num4 = -1234.567
        Console.WriteLine("num3=1234.567   num4=-1234.567 的N3和n格式分別為 :")
        Console.WriteLine("num3={0:N3}   num4={1:n} ", num3, num4)
        Console.WriteLine()

        num1 = 123
        num2 = -123
        Console.WriteLine("num1=123     num2=-123 的 X 格式分別為:")
        Console.WriteLine("num1={0:X}      num2={1:x} ", num1, num2)
        Console.Read()

    End Sub

End Module
