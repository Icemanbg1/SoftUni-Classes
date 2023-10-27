using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exer._8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two integers.Calculate the factorial of each number. Divide the
            // first result by the second and print the result of the division
            // formatted to the second decimal point.
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double factorial1 = FirstFactorial(firstNumber);
            double factorial2 = SecondFactorial(secondNumber);
            double sum = factorial1 / factorial2;
            Console.WriteLine($"{sum:f2}");

        }

        static double SecondFactorial(double secondNumber)
        {
            double sum = 1;
            for (int i = 1;  i <= secondNumber; i++)
            {
                sum *= i;
            }

            return sum;
        }

        static double FirstFactorial(double firstNumber)
        {
            double sum = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
