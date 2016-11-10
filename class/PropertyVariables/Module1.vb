Module Module1

    Class Car
        Public Speed As Integer   ' 宣告Speed為Public公用變數
    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.Speed = 100       ' 物件建立之後可直接使用「.」存取該屬性
    End Sub

End Module
