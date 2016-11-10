Namespace IBM
    Namespace Taiwan            ' 子命名空間 Taiwan
        Class Notebook

        End Class
    End Namespace

    Namespace Japan             ' 子命名空間 Japan
        Class Notebook

        End Class
    End Namespace
End Namespace

Namespace Apple
    Class Notebook

    End Class
End Namespace

Module Module1

    Sub Main()
        ' 使用IBM的Taiwan子命名空間下的Notebook類別建立A物件
        Dim A As New IBM.Taiwan.Notebook()
        ' 使用IBM的Japan子命名空間下的Notebook類別建立A物件
        Dim B As New IBM.Japan.Notebook()
        ' 使用Apple命名空間下的Notebook類別建立C物件
        Dim C As New Apple.Notebook()
    End Sub

End Module
