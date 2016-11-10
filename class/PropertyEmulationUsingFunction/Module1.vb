Module Module1

    Class Car
        ' 宣告_speed為私有變數，表示該變數只能在Car類別內使用
        Private _speed As Integer
        ' 定義GetSpeed()方法用來傳回_speed
        Public Function GetSpeed() As Integer
            Return _speed
        End Function
        ' 定義SetSpeed()方法用來設定_speed
        Public Sub SetSpeed(ByVal vSpeed As Integer)
            If vSpeed < 0 Then vSpeed = 0 ' 設定速度不得低於 0
            If vSpeed > 200 Then vSpeed = 200 ' 設定速度不得高於 200
            _speed = vSpeed
        End Sub
    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.SetSpeed(500)         ' 速度值超過 200
        Console.WriteLine(Benz.GetSpeed()) ' 顯示速度最大值200
        Console.Read()
    End Sub

End Module
