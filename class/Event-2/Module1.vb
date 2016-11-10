Module Module1

    Class Car
        Private _speed As Integer

        Public Event Danger(ByVal vSpeed As Integer) ' 宣告事件

        Public Property Speed() As Integer             ' 定義 Speed 屬性
            Get
                Return (_speed)
            End Get
            Set(ByVal value As Integer)
                If Value > 200 Then
                    RaiseEvent Danger(value)               ' 啟動事件
                End If
                _speed = value
            End Set
        End Property

    End Class

    Dim WithEvents Benz As Car      ' 使用 WithEvents 宣告物件變數
    ' 自動產生的事件程序   
    Public Sub Benz_Danger(vSpeed As Integer) Handles Benz.Danger
        Console.WriteLine("你的目前的速度是 {0}, 超過 200，請減速 !!!", vSpeed.ToString())
    End Sub

    Sub Main()
        Benz = New Car()        ' 建立物件
        Benz.Speed = 300
        Console.Read()
    End Sub

End Module
