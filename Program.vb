Imports System

Module Program
    Sub Main()
        Dim Str1 As String
        Dim Vcount As Integer = 0

        Console.WriteLine("Enter a string")
        Str1 = Console.ReadLine()

        For Each c As Char In Str1
            Select Case Char.ToLower(c)
                Case "a", "e", "i", "o", "u"
                    Vcount = Vcount + 1
            End Select
        Next

        Console.WriteLine("The count of vowel characters in the string is: " & Vcount)

    End Sub
End Module
