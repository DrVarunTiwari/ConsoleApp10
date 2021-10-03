Module Module3
    Sub Main()
        Dim i As Integer
        Dim p As New ArrayList

        p.Add(30)
        p.Add(40)
        p.Add(50)
        p.Add(10)
        For i = 0 To p.Count - 1
            Console.WriteLine(p(i))
        Next
        p.Insert(2, 78)
        p.Remove(50)
        p.RemoveAt(1)
        Console.WriteLine("After inserting and removing element")
        For i = 0 To p.Count - 1
            Console.WriteLine(p(i))
        Next
        Console.ReadLine()
    End Sub

End Module
