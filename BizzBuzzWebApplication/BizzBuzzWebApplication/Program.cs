using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var fizzBuzzService = new FizzBuzzService();

        Console.WriteLine("Enter values separated by spaces:");
        string input = Console.ReadLine();
        if (input != null)
        {
            string[] values = input.Split(' ');

            foreach (var value in values)
            {
                List<string> operations;
                string result = fizzBuzzService.ProcessValue(value, out operations);

                Console.WriteLine(result);
                foreach (var operation in operations)
                {
                    Console.WriteLine(operation);
                }
            }
        }
        else
        {
            Console.WriteLine("No input provided.");
        }
    }
}
