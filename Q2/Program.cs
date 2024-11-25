using System;

namespace BeginnerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;

            
            Console.WriteLine("Please enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
                sum += numbers[i]; 
            }

            
            Console.WriteLine("\nThe numbers you entered are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            
            Console.WriteLine($"\nThe sum of all numbers is: {sum}");
        }
    }
}
