using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Create a program that receives three lines of input:
            //    • On the first line – a string – "add", "multiply", "subtract", "divide".
            //    • On the second line – a number.
            //    • On the third line – another number.
            //    You should create four methods(for each calculation) and invoke the
            //    corresponding method depending on the command.The method should also
            //    print the result(needs to be void).

            string calculation = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (calculation == "add")
            {
                Add(number1, number2);
            }
            else if (calculation == "multiply")
            {
                Multiply(number1, number2);
            }
            else if (calculation == "subtract")
            {
                Subtract(number1, number2);
            }
            else if (calculation == "divide")
            {
                Divide(number1, number2);
            }
        }

        static void Add(double number1, double number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Multiply(double number1, double number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void Subtract(double number1, double number2)
        {
            Console.WriteLine(number1 - number2);
        }

        static void Divide(double number1, double number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
