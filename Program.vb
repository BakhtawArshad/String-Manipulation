Module Main
    Sub Main()
        Dim alpha As String
        Console.Write("Enter s string:")
        alpha = Console.ReadLine()

        Dim isLowercase As Boolean = True

        For Each Letter As Char In alpha
            If Letter <> Char.ToLower(Letter) Then
                isLowercase = False
                Exit For

            End If
        Next

    End Sub



End Module
