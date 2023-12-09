Imports System

Module Program
    Sub BothEnds()
        Dim str1, Str2 As String
        Dim Char1 As Char
        Char1 = ""
        Str2 = ""
        str1 = ""
        Console.Write("Enter a string: ")
        str1 = Console.ReadLine()

        For i = 1 To Len(str1)
            Char1 = Mid(str1, i, 1)
            'check if the length of the string is less then 2
            If str1.Length < 2 Then
                str1 = str1 + Char1
            Else
                Str2 = Str2 & str1
            End If
        Next
    End Sub
End Module
