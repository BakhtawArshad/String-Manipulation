Imports System

Module Module1
    Sub Main()

        Dim a As String = Console.ReadLine()
        Dim b As String = Console.ReadLine()
        Dim result As String = MixUp(a, b)

        a = ""
        b = ""
        result = ""
        Console.Write("Enter the first string (a): ")
        Console.Write("Enter the second string (b): ")
    End Sub
    Function MixUp(a As String, b As String) As String
        Dim mixedString As String = b.Substring(0, 2) & a.Substring(2) & " " & a.Substring(0, 2) & b.Substring(2)
        Return mixedString
    End Function
End Module

