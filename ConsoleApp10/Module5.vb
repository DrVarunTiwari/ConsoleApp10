Module Module5
    Structure gs
        Dim bs As Integer
        Dim ta, hra, da, gs As Single
    End Structure
    Sub Main()
        Try
            Console.WriteLine("hellloooo")
        Catch ex As Exception
            Console.WriteLine(ex.Message())
        Finally
            Dim a As gs
            a.bs = 2200
            a.ta = a.bs * 0.8
            a.hra = a.bs * 0.9
            a.da = a.bs * 0.8
            a.gs = a.bs + a.ta + a.hra + a.da
            Console.WriteLine(a.gs)
        End Try
        Console.ReadLine()

    End Sub
End Module
