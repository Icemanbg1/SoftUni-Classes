using System;
using System.Collections.Generic;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will receive two whole numbers from the console representing
            // the start and the end of a sequence of numbers.
            // Your task is to print two lines:
            // • On the first line, print all numbers from the start of the sequence to the end inclusive
            // • On the second line, print the sum of the sequence in the format: "Sum: {sum}".

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"{i} ");
                sum = i + sum;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
