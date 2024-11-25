
using System;

class Program
{
    
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        
        Console.WriteLine($"The square of {input} is {SquareNumber(input)}");
    }
}
