Module Module6
    Class emp
        Private eid As Integer
        Private ename As String
        Public Property empno As Integer
            Get
                Return eid
            End Get
            Set(value As Integer)
                eid = value
            End Set
        End Property
        Public Property name As String
            Get
                Return ename
            End Get
            Set(value As String)
                ename = value
            End Set
        End Property
    End Class
    Sub Main()
        Dim p As New emp
        p.empno = 1101
        p.name = "Rajesh"
        Console.WriteLine("eid: " & p.empno)
        Console.WriteLine("name: " & p.name)
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub
End Module




