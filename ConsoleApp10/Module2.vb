Module Module2
    Sub Main()
        Dim a(2, 2), b(2, 2), d(2, 2) As Integer
        Dim r, c As Integer
        For r = 0 To 1
            For c = 0 To 1
                a(r, c) = InputBox("Enter First Matrix Value-:")
            Next c
        Next r
        For r = 0 To 1
            For c = 0 To 1
                b(r, c) = InputBox("Enter Second Matrix Value-:")
            Next c
        Next r
        Console.WriteLine("Addition of Matrix1 and Matrix2: ")
        For r = 0 To 1
            For c = 0 To 1
                Console.WriteLine("{0} ", d(r, c))
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()



    End Sub
End Module
