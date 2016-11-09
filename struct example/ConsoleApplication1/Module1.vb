Module Module1
    Structure student
        Public ID, score As Integer
        Public name As String
    End Structure
    Sub Main()
        Dim Peter, Mary As student
        Console.Write("請輸入學生ID:")
        Peter.ID = Console.ReadLine()
        Console.Write("請輸入學生姓名:")
        Peter.name = Console.ReadLine()
        Console.Write("請輸入學生成績:")
        Peter.score = Console.ReadLine()
        Console.Write("請輸入學生ID:")
        Mary.ID = Console.ReadLine()
        Console.Write("請輸入學生姓名:")
        Mary.name = Console.ReadLine()
        Console.Write("請輸入學生成績:")
        Mary.score = Console.ReadLine()
        Console.WriteLine("{0}的ID是{1}，成績是{2}", Peter.name, Peter.ID, Peter.score)
        Console.WriteLine("{0}的ID是{1}，成績是{2}", Mary.name, Mary.ID, Mary.score)
        Console.Read()

    End Sub

End Module
