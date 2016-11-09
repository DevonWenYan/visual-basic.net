Module Module1

    ' 定義Product產品結構資料型別
    Structure Product
        ' Product產品結構內含No編號欄位、Name品名欄位、Price單價欄位
        Public No, Name As String
        Public Price As Integer
    End Structure

    Sub Main()


        ' 宣告game結構變數為Product結構型別
        Dim game As Product
        ' 設定game.No編號欄位的值為 "G01"
        game.No = "G01"
        ' 設定game.Name品名欄位的值為"XBox One"
        game.Name = "XBox One"
        ' 設定game.Price單價欄位的值為15000
        game.Price = 15000
        Dim App As Product        ' 宣告App結構變數為Product結構型別
        Console.Write(" 請輸入產品編號：")
        ' 由鍵盤輸入編號再指定給App.No編號欄位
        App.No = Console.ReadLine()
        Console.Write(" 請輸入產品名稱：")
        ' 由鍵盤輸入品名再指定給App.Name品名欄位
        App.Name = Console.ReadLine()
        Console.Write(" 請輸入產品單價：")
        ' 由鍵盤輸入單價並轉成數值資料再指定給App.Price單價欄位
        App.Price = Val(Console.ReadLine())
        Console.WriteLine()
        Console.WriteLine(" ====== 產品單價清單 ====== ")
        Console.WriteLine()
        ' 印出game及App結構的編號、品名及單價
        Console.WriteLine(" 產品編號：{0} ", game.No)
        Console.WriteLine(" 產品名稱：{0} ", game.Name)
        ' 將使用ToString()方法將game.Price單價轉成字串再顯示在主控台
        Console.WriteLine(" 產品單價：{0} ", game.Price.ToString())
        Console.WriteLine(" 產品編號：{0} ", App.No)
        Console.WriteLine(" 產品名稱：{0} ", App.Name)
        Console.WriteLine(" 產品單價：{0} ", App.Price.ToString())
        Console.Read()
    End Sub


End Module
