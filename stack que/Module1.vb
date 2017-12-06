Module Module1

    Sub Main()
        Dim stack(100) As Integer
        Dim top As Integer
        Dim que(100) As Integer
        Dim start, bottom As Integer
        Dim choice As Integer = 100
        While choice <> 0
            printMenu()
            choice = Console.ReadLine
            If choice = 1 Then
                Console.WriteLine("enter value")
                push(Console.ReadLine, stack, top)
            ElseIf choice = 2 Then
                Console.WriteLine(pop(stack, top) & " was popped")
            ElseIf choice = 3 Then
                Console.WriteLine("input value")
                enque(Console.ReadLine, que, bottom)
            ElseIf choice = 4 Then
                Console.WriteLine(deque(que, start) & "was dequed")
            ElseIf choice = 5 Then
                Console.Write("que: ")
                printarr(que)
                Console.Write("stack: ")
                printarr(stack)
            Else
                Console.WriteLine("wrong choice")
            End If

        End While
    End Sub

    Sub push(ByVal input As Integer, ByRef stack() As Integer, ByRef top As Integer)
        top += 1
        stack(top) = input
    End Sub

    Function pop(ByRef stack() As Integer, ByRef top As Integer)
        Dim out = stack(top)
        stack(top) = 0
        top -= 1
        Return out
    End Function

    Sub enque(ByVal input As Integer, ByRef que() As Integer, ByRef bottom As Integer)
        bottom += 1
        que(bottom) = input
    End Sub

    Function deque(ByRef que() As Integer, ByRef top As Integer)
        Dim out = que(top)
        que(top) = 0
        top -= 1
        Return out
    End Function

    Sub printMenu()
        Console.WriteLine("select an option")
        Console.WriteLine("1: push")
        Console.WriteLine("2: pop")
        Console.WriteLine("3: enque")
        Console.WriteLine("4: deque")
        Console.WriteLine("5: view stack and que")
        Console.WriteLine("0: quit")
    End Sub

    Sub printarr(ByVal arr() As Integer)
        For i = 0 To arr.Length - 1
            Console.Write(arr(i) & ", ")
        Next
        Console.WriteLine()
    End Sub
End Module
