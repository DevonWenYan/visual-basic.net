Module Module1

    Class Car      ' 定義Car類別
        ' 宣告_speed為私有變數，表示該變數只能在Car類別內使用
        Private _speed As Integer
        ' 宣告Speed為公用屬性
        Public Property Speed() As Integer
            Get    ' Get程序可傳回屬性值
                Return _speed           ' 傳回屬性值
            End Get
            Set(ByVal value As Integer)   '  Set程序可設定屬性值
                If value < 0 Then value = 0 ' 速度不得低於 0
                If value > 200 Then value = 200 ' 速度不得高於 200
                _speed = value      ' 設定屬性值
            End Set
        End Property
    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.Speed = 500            ' 速度值超過 200
        Console.WriteLine(Benz.Speed)
        Console.Read()
    End Sub

End Module
