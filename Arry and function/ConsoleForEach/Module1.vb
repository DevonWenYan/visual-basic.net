Module Module1

    Sub Main()
        ' 宣告 i 整數變數為 for 迴圈的計數變數
        ' 宣告 num整數變數用來存放總人數
        ' 宣告 sum整數變數用來存放總人數身高的加總
        Dim i, num, sum As Integer
        Console.Write("請輸入總人數 : ")
        ' 使用者由鍵盤輸入總人數後並轉成整數資料再指定給num變數
        num = Val(Console.ReadLine())
        ' 建立 tall 整數陣列，陣列索引範圍是 tall(0)~tall(num-1)
        Dim tall(num - 1) As Integer
        ' 使用迴圈讓使用者逐一輸入每一位的身高
        For i = 0 To tall.GetUpperBound(0)
            ' 逐一輸入每一位的身高
            Console.Write("請輸入第 {0} 位身高:", (i + 1).ToString())
            tall(i) = Val(Console.ReadLine())
        Next
        ' 計算總人數身高的加總
        For Each height As Integer In tall
            ' 將tall陣列中所有的元素加總並指定給sum
            sum += height
        Next
        ' 顯示平均身高
        Console.WriteLine("平均身高: {0}", CInt((sum / num)).ToString())
        Console.Read()
    End Sub

End Module
