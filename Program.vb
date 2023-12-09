

Module Program
    Sub Main()
        Dim str As String
        Dim chcount As New Dictionary(Of Char, Integer)

        Console.Write("Enter a string:")
        str = Console.ReadLine

        'count the character that appears most number of time
        For Each c As Char In str
            If chcount.ContainsKey(c) Then
                chcount(c) = chcount(c) + 1
            Else
                chcount.Add(c, 1)

            End If
        Next

        For Each kvp As KeyValuePair(Of Char, Integer) In chcount
            Console.WriteLine("character:" & kvp.Key & ",count:" & kvp.Value)

        Next
    End Sub
End Module
