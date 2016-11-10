Module Module1
    Class Car   ' 定義Car類別
        Private _speed As Integer = 0
        Public Property Speed() As Integer
          get
                Return _speed
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 200 Then value = 200
                _speed = value
            End Set
        End Property

        ' 第一種加速方法
        Public Sub Accelerate()
            Me.Speed += 1
        End Sub
        ' 第二種加速方法
        Public Sub Accelerate(ByVal addSpeed As Integer)
            Me.Speed += addSpeed
        End Sub
        ' 第三種加速方法
        Public Sub Accelerate(ByVal S As String)
            If S = "STOP" Then Me.Speed = 0
        End Sub
    End Class

    Sub Main()
        Dim Benz As New Car()
        Console.WriteLine("現在速度:{0}", Benz.Speed)
        Console.WriteLine("加速 ...")
        Benz.Accelerate()        ' 執行第一種加速方法
        Console.WriteLine("現在速度:{0}", Benz.Speed)
        Console.WriteLine("加速 10 ...")
        Benz.Accelerate(10)      ' 執行第二種加速方法
        Console.WriteLine("現在速度:{0}", Benz.Speed)
        Console.WriteLine("停車 ...")
        Benz.Accelerate("STOP") '	 執行第三種加速方法
        Console.WriteLine("現在速度:{0}", Benz.Speed)
        Console.Read()
    End Sub

End Module
