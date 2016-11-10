Module Module1

    Class Car       ' 定義Car類別
        ' 宣告私有變數_x, _y用來表示目前車子的X, Y座標位置
        Private _x, _y As Integer
        ' 定義Movie方法，用來設定目前車子的X, Y座標位置
        Public Sub Move(ByVal vX As Integer, ByVal vY As Integer)
            _x = vX
            _y = vY
        End Sub
    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.Move(100, 200)
    End Sub

End Module
