Imports System

Module Program
    Sub CountCharacters()
        Dim Str As String
        Dim Character As Char
        Dim count As Integer = 0
        Dim AlphaCount As Integer = 0
        Dim digitCount As Integer = 0
        Dim otherCount As Integer = 0

        Console.WriteLine("Enter a string:")
        Str = Console.ReadLine()

        Console.WriteLine("Enter a character to count:")
        Character = Console.ReadLine()(0)

        For Each c As Char In Str
            If Char.ToLower(c) = Char.ToLower(Character) Then
                count = count + 1
            End If

            If Char.IsLetter(c) Then
                AlphaCount = AlphaCount + 1
            ElseIf Char.IsDigit(c) Then
                digitCount = digitCount + 1
            Else
                otherCount = otherCount + 1
            End If
        Next

    End Sub
End Module
