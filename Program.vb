Module Module1
    Sub Main()
        Dim input As String
        Console.Write("Enter a string:")
        input = Console.ReadLine()


        Dim char1 As Char
        Console.Write("Enter the cahracter to replace")
        char1 = Console.ReadKey().KeyChar
        Console.WriteLine()

        Dim char2 As Char
        Console.WriteLine("enter the character to replace with")
        char2 = Console.ReadKey().KeyChar
        Console.WriteLine()

        Dim newstring As String = input.Replace(char1, char2)

        Console.WriteLine("Result:" & newstring)

    End Sub


End Module
