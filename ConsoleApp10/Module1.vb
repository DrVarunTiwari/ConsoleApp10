Module Module1
    Sub Main()
        Dim p(3) As Integer
        p(0) = 12
        p(1) = 13
        p(2) = 14
        Console.WriteLine(p(1))
        ReDim p(5)
        p(4) = 33
        p(3) = 44
        MsgBox(p(3))
        Console.ReadLine()
    End Sub
End Module
