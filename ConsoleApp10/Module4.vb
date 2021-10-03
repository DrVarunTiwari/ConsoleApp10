Module Module4
    Enum year
        jan
        feb
        march
        april
        may
        june
    End Enum
    Const p As Integer = 10
    Sub Main()
        Console.WriteLine(year.feb.ToString(), CInt(year.jan))
        Console.WriteLine(p)
        Console.ReadLine()
    End Sub
End Module
