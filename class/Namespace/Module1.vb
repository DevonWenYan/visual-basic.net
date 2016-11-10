Namespace IBM               ' 定義 IBM 命名空間
    Class Notebook

    End Class
End Namespace

Namespace Apple         ' 定義 Apple命名空間
    Class Notebook

    End Class
End Namespace

Module Module1

    Sub Main()
        ' 使用IBM命名空間下的Notebook類別建立A物件
        Dim A As New IBM.Notebook()
        ' 使用Apple命名空間下的Notebook類別建立B物件
        Dim B As New Apple.Notebook()
    End Sub

End Module
