Imports System

Module Program
    Sub fixstart()
        Dim String1 As String = Console.ReadLine()
        Dim result As String = FixStart(String1)
        String1 = ""
        result = ""
        Console.Write("Enter a string: ")
        Console.WriteLine($"Result: {result}")
    End Sub
    Function FixStart(str As String) As String
        Dim firstChar As Char = str(0)
        Dim modifiedString As String = firstChar

        firstChar = ''
        modifiedString = ""

        For i As Integer = 1 To str.Length - 1
            If str(i) = firstChar Then
                modifiedString &= "*"
            Else
                modifiedString &= str(i)
            End If
        Next
        Return modifiedString
    End Function
End Module
