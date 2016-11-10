Module Module1

    Sub Main()
        ' 建立和設定不規則陣列初值
        Dim amt(2)() As Double
        ' 建立amt(0)(0)~amt(0)(2)陣列元素, 存放台北分公司第一, 二, 三處的金額
        amt(0) = New Double() {1100, 2200, 3300}
        ' 建立amt(1)(0)~amt(1)(1)陣列元素, 存放台中分公司第一, 二處的金額
        amt(1) = New Double() {1500, 2500}
        ' 建立amt(2)(0)~amt(2)(3)陣列元素, , 存放高雄分公司第一, 二, 三, 四處的金額
        amt(2) = New Double() {1000, 2000, 3000, 4000}
        ' 建立 company(0)~company(2)用來存放三個分公司的名稱
        Dim company() As String = {"台北", "台中", "高雄"}
        ' 建立 sum(0)~sum(2)用來存放台北, 台中, 高雄各分公司的營業額
        Dim sum() As Double = {0.0, 0.0, 0.0}
        Dim total As Double = 0 ' 總營業額
        Console.WriteLine("{0}第一處{1}第二處{2}第三處{3}第四處  (單位：千元)", vbTab, vbTab, vbTab, vbTab)
        For i As Integer = 0 To amt.Length - 1
            For k As Integer = 0 To amt(i).Length - 1
                Console.Write("{0}{1}", vbTab, amt(i)(k).ToString()) ' 顯示各處的金額
                sum(i) += amt(i)(k)           ' 計算各公司的營業額
            Next
            total += sum(i) * 1000        ' 計算總營業額
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine()
        For n As Integer = 0 To company.Length - 1
            sum(n) *= 1000
            Console.WriteLine("{0}分公司營業額：{1}元{2}營業率：{3:p}", company(n), sum(n).ToString("c"), vbTab, (sum(n) / total))
        Next
        Console.WriteLine("總營業額：{0}元", total.ToString("c"))
        Console.Read()
    End Sub

End Module
