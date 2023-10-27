using System;
using System.Threading;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method, which receives two numbers as parameters:
            //    • The first number – the base
            //    • The second number – the power
            //The method should return the base raised to the given power.
            double base1 = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            Method(base1, power);
        }

        static void Method(double base1, int power)
        {
            double sum = 1;
            for (int i = 0; i < power; i++)
            {
                sum *= base1;
            }

            Console.WriteLine(sum);
        }
    }
}
