﻿Module Module1

    Sub Main()
        ' 建立RoleName(0)~RoleName(4)用來存放角色姓名
        Dim RoleName() As String = {"魯夫", "喬巴", "羅賓", "香吉士", "騙人布"}
        ' 建立Money(0)~Money(4) 用來存放角色的懸賞金額
        Dim Money() As Integer = {300000000, 50, 78000000, 77000000, 30000000}
        Console.WriteLine("==草帽海賊團成員(遞增排序)==")
        Console.WriteLine()
        Console.WriteLine("姓名{0}懸賞金額", vbTab)
        Console.WriteLine("==================")
        ' Money 陣列遞增排序，且RoleName亦跟著更動
        Array.Sort(Money, RoleName)
        Dim i As Integer  ' 宣告 i 為for迴圈計數變數
        ' 陣列的GetUpperBound()方法可用來取得某一維度的上限
        ' 因此RoleName.GetUpperBound(0) 會傳回 4
        For i = 0 To RoleName.GetUpperBound(0)
            ' 顯示RoleName(0)~RoleName(4) 及Money(0) ~Money(4) 
            Console.WriteLine("{0}{1}{2}", RoleName(i), vbTab, Money(i).ToString())
        Next
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("==草帽海賊團成員(遞減排序)==")
        Console.WriteLine()
        Console.WriteLine("姓名{0}懸賞金額", vbTab)
        Console.WriteLine("==================")
        ' Money 陣列遞增排序，且RoleName亦跟著更動
        Array.Sort(Money, RoleName)
        ' 反轉Money陣列，使Money陣列變成遞減排序
        Array.Reverse(Money)
        Array.Reverse(RoleName)   ' 反轉RoleName陣列
        For i = 0 To RoleName.GetUpperBound(0)
            Console.WriteLine("{0}{1}{2}", RoleName(i), vbTab, Money(i).ToString())
        Next
        Console.Read()
    End Sub

End Module
