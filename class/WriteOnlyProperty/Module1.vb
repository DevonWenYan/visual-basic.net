Module Module1

    Class Car   ' 定義Car類別
        Private _turbo As Boolean = False
        Public WriteOnly Property Turbo() As Boolean     ' 定義Turbo唯寫屬性
            ' Turbo屬性只有Set程序沒有Get程序
            Set(ByVal value As Boolean)
                _turbo = value
            End Set
        End Property

    End Class

    Sub Main()
        Dim Benz As New Car()
        Benz.Turbo = True  ' Turbo屬性只能寫不能讀
    End Sub

End Module
