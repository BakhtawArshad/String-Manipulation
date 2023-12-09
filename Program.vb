Imports System

Module Program
    Sub Main()
        Console.Write("Enter a string: ")
        Dim inputString As String = Console.ReadLine()
        Dim result As String = NotBad(inputString)
    End Sub
    Function NotBad(s As String) As String
        Dim NIndex As Integer = s.IndexOf("not")
        Dim BIndex As Integer = s.IndexOf("bad")

        If NIndex <> -1 Then AndAlso BIndex <> -1 AndAlso BIndex > NIndex Then
            Return s.Substring(0, NIndex) & "good" & s.Substring(BIndex + 3)
        Else
        Return s
        End If


    End Function


End Module
