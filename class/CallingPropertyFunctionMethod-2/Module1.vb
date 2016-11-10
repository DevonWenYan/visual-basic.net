Module Module1
    Class Car   ' 定義Car類別
        ' 宣告_speed私有變數用來存放車子的速度值
        Private _speed As Integer = 0
        ' 定義Speed速度屬性
        Public Property Speed() As Integer
            Get
                Return _speed  ' 傳回目前的速度
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0 ' 速度不可小於0
                If value > 200 Then value = 200 ' 速度不可大於200
                _speed = value                 ' 設定速度
            End Set
        End Property

        ' 定義Accelerate()方法，用來指定目前車子速度+1 
        Public Sub Accelerate()
            Me.Speed += 1              ' 速度 + 1
            If Me.Speed > 200 Then Speed = 200 ' 檢查速度不可超過 200
        End Sub
    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.Speed = 199
        Console.WriteLine("現在速度:{0}", Benz.Speed.ToString())
        Console.WriteLine("加速 ...")
        Benz.Accelerate()
        Console.WriteLine("現在速度:{0}", Benz.Speed.ToString())
        Console.WriteLine("加速 ...")
        Benz.Accelerate()
        Console.WriteLine("現在速度:{0}", Benz.Speed.ToString())
        Console.Read()
    End Sub

End Module
