Module Module1

    Class Student
        Private _Height, _Weight As Integer
        ' Student類別的建構式，無引數
        Sub New()
            _Weight = 48
            _Height = 160
        End Sub
        ' Student類別的建構式，須設定一個引數
        Sub New(ByVal w As Integer)
            _Weight = w       ' 初始化_Weight欄位
            _Height = 160         ' 初始化_Height欄位的值為160
        End Sub
        ' Student類別的建構式，須設定兩個引數
        Sub New(ByVal w As Integer, ByVal h As Integer)
            _Weight = w
            _Height = h
        End Sub
        ' Student類別的GetShow()方法，可顯示學生的身高和體重
        Public Sub GetShow()
            Console.WriteLine(" 身高是: {0} ", _Height.ToString())
            Console.WriteLine(" 體重是: {0} ", _Weight.ToString())
            Console.WriteLine()
        End Sub
    End Class

    Sub Main()
        Dim Peter As New Student()
        Console.WriteLine(" Peter的資料-->使用Student()建構式")
        peter.GetShow()
        Dim David As New Student(56)
        Console.WriteLine(" David的資料-->使用Student(56)建構式")
        David.GetShow()
        Dim Mary As New Student(48, 150)
        Console.WriteLine(" Mary的資料 -->使用Student(48, 150)建構式")
        Mary.GetShow()
        Console.Read()
    End Sub

End Module
