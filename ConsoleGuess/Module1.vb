Module Module1

    Sub Main()
        ' 宣告keyin整數變數存放使用者所欲猜的數字
        ' 宣告guess整數變數用來存放電腦產生的亂數
        ' 宣告count整數變數用來存放使用者進行猜數字的次數
        ' 宣告min整數變數用來存放猜數字的最小值
        ' 宣告max整數變數用來存放猜數字的最大值
        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 0
        max = 100
        ' 建立亂數物件r
        Dim r As New Random()
        ' 透過亂數物件r的Next方法產生1-99之間的亂數並指定給guess
        guess = r.Next(1, 100)
        Console.WriteLine("======= 猜數字遊戲 =======")
        Console.WriteLine()
        Do
            Console.Write("猜數子範圍 {0} < ? < {1} ：", min, max)
            ' 透過int.Parse()方法將輸入的資料轉成數值後，再指定給keyin變數 
            keyin = Val(Console.ReadLine())
            If (keyin < min Or keyin > max) Then
                Console.WriteLine("請輸入提示範圍內的數字!")
                Continue Do
            End If
            count += 1
            If keyin >= 1 And keyin < 100 Then      ' 判斷keyin是於介於1-99
                If keyin = guess Then        ' 若keyin等於guess，表示猜對了
                    Console.WriteLine("賓果!猜對了, 答案是 {0}", guess)
                    Exit Do
                ElseIf keyin > guess Then
                    ' 若keyin大於guess，表示所猜的數字大於guess
                    max = keyin     ' 將目前輸入的數字keyin指定給max
                    Console.Write("再小一點!!")
                ElseIf keyin < guess Then
                    ' 若keyin小於guess，表示所猜的數字小於guess
                    min = keyin   ' 將目前輸入的數字keyin指定給min
                    Console.Write("再大一點!!")
                End If
                Console.WriteLine(" 您猜了 {0} 次", count.ToString())
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入提示範圍內的數字!")
            End If
        Loop While True   ' 指定do{...}while(True)為無窮迴圈
        Console.Read()
    End Sub

End Module
