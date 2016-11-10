Module Module1
    Const PI As Double = 3.14

    Sub Main()
        ' create a three element array of integers
        ' 宣告建立一維整數陣列,並設定初值
        Dim intArray() As Integer = New Integer() {2, 3, 4}

        ' 對ShowArea()方法設定一個委派(Delegate)
        ' 即設定 myAction 的動作為呼叫ShowArea()方法
        ' ShowArea方法的虛引數為整數資料
        Dim action As New Action(Of Integer)(AddressOf ShowArea)

        ' 逐一對取出的陣列元素執行myAction指定的動作
        Array.ForEach(intArray, action)
        Console.Read()

    End Sub
    ' 由傳入的半徑計算並顯示圓面積的ShowArea()方法
    Sub ShowArea(r As Integer)
        Console.WriteLine(vbNewLine & " 半徑 : {0:d} 的圓面積為 {1:f}", r, PI * r * r)
    End Sub

End Module
