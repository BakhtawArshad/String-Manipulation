Imports System

Module Program
    Sub Donuts()
        Dim Count1 As Integer
        Dim output As String
        Count1 = 0

        If Count1 >= 10 Then
            output = "Number of donuts: many"
        Else
            output = "Number of donuts: " & Count1.ToString()
        End If

        Console.WriteLine(output)
    End Sub
End Module
