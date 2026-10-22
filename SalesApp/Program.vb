Imports System

Module Program
    Sub Main(args As String())
        Dim n as Integer
        Dim price, total as Double
        Dim ucase, pname as String
        Dim tax as Double = 0.05
        System.Console.Write("Enter the name of the product: ")
        pname = System.Console.ReadLine()
        System.Console.Write("Enter the quantity of the product: ")
        n = System.Console.ReadLine()
        System.Console.Write("Enter the unit price of the product: ")
        price = System.Console.ReadLine()
        ucase = pname.ToUpper
        total = n * price * (1.0 + tax)

        Console.Write("Total amount of money to be paid for product ")
        Console.WriteLine(" {0} is ${1} ", ucase, total)
    End Sub
End Module
