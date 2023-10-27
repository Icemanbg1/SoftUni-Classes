using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

using static System.Net.Mime.MediaTypeNames;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program, which sums the ASCII codes of n characters and prints the sum on the console.


            // Input
            // • On the first line, you will receive n – the number of lines, which will follow.
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            // • On the next n lines – you will receive letters from the Latin alphabet.
            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                totalSum += character;
            }
            Console.WriteLine($"The sum equals: {totalSum}");


            // Output
            // Print the total sum in the following format:
            //            "The sum equals: {totalSum}"


            // Constraints
            // • n will be in the interval[1…20].
            // • The characters will always be either upper or lower -case letters from the English alphabet.
            // • You will always receive one letter per line.

        }
    }
}
