Module Module1

    Class Car
        Private _speed As Integer
        Public Event Danger(ByVal vSpeed As Integer)  ' 宣告事件

        Public Property Speed() As Integer               ' 定義 Speed 屬性
            Get
                Return (_speed)
            End Get
            Set(ByVal value As Integer)
                ' 當value大於200時即啟動事件
                If value > 200 Then
                    ' 啟動事件
                    RaiseEvent Danger(value)
                End If
                _speed = value
            End Set
        End Property

    End Class

    ' 事件處理程序    
    Sub TooFast(ByVal vSpeed As Integer)
        Console.WriteLine("你的目前的速度是 {0}, 超過 200，請減速 !!!", vSpeed)
    End Sub

    Sub Main()
        Dim Benz As New Car()
        ' 指定 Danger 事件由 TooFast 程序來處理
        Do
            AddHandler(Benz.Danger), AddressOf TooFast
            Benz.Speed = Console.ReadLine()
        Loop While Benz.Speed > 200
        Console.Read()
    End Sub

End Module
