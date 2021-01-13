Module Module1

    Sub Main()
        Dim userinput, X, N As Integer
        Dim count As Integer

        userinput = 0
        count = 0

        Console.WriteLine("This algorithm outputs the first 5 square numbers which comes after whatever number you enter. i.e input = 3 will give you a square of 3, 4, 5, 6, 7 and 8.")
        Console.WriteLine("Your input: ")
        userinput = Console.ReadLine()
        Console.WriteLine("*******")

        X = userinput * userinput
        Console.WriteLine(X)

        For count = 0 To 4
            userinput = userinput + 1
            X = userinput * userinput
            Console.WriteLine(X)
        Next count

        Console.ReadKey()

    End Sub

End Module
