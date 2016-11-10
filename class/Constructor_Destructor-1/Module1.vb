Module Module1

    Class Car  ' 定義Car 類別
        Private _speed As Integer = 0

        ' 物件的建構式 #1        
        Public Sub New()
            _speed = 0
            Console.WriteLine("初始化後速度 = {0}", _speed)
        End Sub

        ' 物件的建構式 #2        
        Public Sub New(ByVal vSpeed As Integer)
            _speed = vSpeed
            Console.WriteLine("初始化後速度 = {0}", _speed)
        End Sub

        ' 物件的解構式    
        Protected Overrides Sub Finalize()
            Console.WriteLine("車子物件消滅了 ...")
        End Sub
    End Class

    Sub DoSomething()
        Console.WriteLine("進入程序，並宣告 BMW 物件 ...")
        Dim BMW As New Car(10)
        Console.WriteLine("BMW 物件宣告完成，準備離開程序 ...")
    End Sub

    Sub Main()
        DoSomething()
        Console.WriteLine("宣告 Benz 物件 ..")
        Dim Benz As New Car()
        Console.WriteLine("Benz 物件宣告完成 ..")
        Console.WriteLine("準備執行 Benz = Nothing ...")
        Benz = Nothing
        Console.WriteLine("Benz = Nothing 執行完成 !!")
        Console.Read()
    End Sub

End Module
