Imports System

Module Program
    Sub Main(args As String())
        Dim eng() as Integer = { 6, 2, 3, 5 }
        Dim math() as Integer = { 1, 2, 3, 4, 5 }
        Dim a_all, a_eng, a_math, y as Double
        Dim i, n as Integer

        n = 4
        y = 0
        Console.WriteLine("Score for English: ")
        For i = 0 to n-1
            Console.WriteLine(eng(i))
            y = y + eng(i)
        Next
        a_eng = y/n     ' average score for english
        Console.WriteLine("and the average = {0} ", a_eng)
        Console.WriteLine("")

        n = 5
        y = 0
        Console.WriteLine("Score for Maths: ")
        For i = 0 to n-1
            Console.WriteLine(math(i))
            y = y + math(i)
        Next
        a_math = y/n     ' average score for math
        Console.WriteLine("and the average = {0} ", a_math)
        Console.WriteLine("")

        a_all = (a_eng + a_math)/2  ' calculate the grand average
        Console.WriteLine("The grand average for both = {0} ", a_all)
        Console.WriteLine("")
    End Sub
End Module
