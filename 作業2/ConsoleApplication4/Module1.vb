Module Module1
    Class SetException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "發生SetException例外類別"
        End Function
        Public Overrides ReadOnly Property Message() As String
            Get
                Return "身高體重不能設定負數或零，請重新輸入"
            End Get
        End Property
    End Class
    Class BMIException
            Inherits Exception

            Public Overrides Function ToString() As String
                Return "發生SBMIException例外類別"
            End Function
            Public Overrides ReadOnly Property Message() As String
                Get
                Return "BMI異常"
            End Get
            End Property
        End Class
        Class student
        Protected Shared _total As Integer = 0
        Private _name As String
        Private _Height As Integer
        Private _Sid As String
        Private _Weight As Integer
        Private _BMI As Double
        Public Property SetData() As String
            Get
                Return _BMI
            End Get
            Set(ByVal value As String)
                Console.WriteLine("請輸入姓名:")
                _name = Console.ReadLine()
                Console.WriteLine("請輸入身高:")
                _Height = Console.ReadLine()
                Console.WriteLine("請輸入體重:")
                _Weight = Console.ReadLine()
                _Sid = value
                _total = _total + 1
                If (_Height <= 0 Or _Weight <= 0) Then
                    Throw New SetException
                End If
                _BMI = _Weight / ((_Height * _Height) / 10000)
                If (_BMI < 18.5 Or _BMI > 24) Then
                    Throw New BMIException
                End If
            End Set
        End Property
        Public Sub ShowBMI()
            Console.WriteLine("總人數為 {0}─ 學號 {1}─ 姓名{2}─ 身高{3}─ 體重{4} ─BMI為{5}", _total, _Sid, _name, _Height, _Weight, SetData().ToString)
        End Sub
    End Class
    Sub Main()
        Dim tom As New student
        Dim key As String
        Do While (True)
            Try
                Console.WriteLine("請輸入學號:")
                tom.SetData() = Console.ReadLine()
                tom.ShowBMI()
                Console.WriteLine("是否結束?若要結束請按q")
                key = Console.ReadLine()
                If (key = "q") Then
                    Exit Do
                End If
            Catch ex As SetException
                Console.WriteLine(ex.ToString())
                Console.WriteLine(ex.Message)
            Catch ex As BMIException
                Console.WriteLine(ex.ToString())
                Console.WriteLine(ex.Message)
                Console.WriteLine("是否結束?若要結束請按q")
                key = Console.ReadLine()
                If (key = "q") Then
                    Exit Do
                End If
            End Try
        Loop
        Console.Read()
    End Sub
End Module