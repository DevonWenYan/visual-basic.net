Module Module1

    Class Car       ' 定義Car類別
        Private _angle As Integer = 10 ' 私有_angle變數初值為10
        Public ReadOnly Property Angle() As Integer       ' 定義Angle唯讀屬性
            ' Angle屬性只有Get程序沒有Set程序
            Get
                Return _angle
            End Get
        End Property
    End Class


    Sub Main()
        Dim Benz As New Car()
        Console.WriteLine(Benz.Angle)  ' Angle只能讀不能寫
        Console.Read()
    End Sub

End Module
