Imports System

Module Program
    Sub verbing()
        Dim String1 As String = Console.ReadLine()
        Dim result As String = Verbing(String1)

        String1 = ""
        result = ""

        Console.Write("Enter a string: ")
        String1 = Console.ReadLine()

    End Sub
    Function Verbing(mooo As String) As String
        If mooo.Length < 3 Then
            Return mooo
        ElseIf mooo.EndsWith("ing") Then
            Return mooo & "ly"
        Else
            Return mooo & "ing"
        End If
    End Function
End Module
