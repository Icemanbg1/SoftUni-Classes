using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives two numbers and an operator, calculates the result and
            // returns it. You will be given three lines of input. The first will be the first number,
            // the second one will be the operator and the last one will be the second number.
            // The possible operators are: /, *, +and -.        }
            int number1 = int.Parse(Console.ReadLine());
            string operatorA = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            Calculations(number1, number2, operatorA);
            
        }

        static void Calculations (int number1, int number2, string operatorA) 
        {
            double sum = 0;
            if (operatorA == "/")
            {
                sum = number1 / number2;
            }
            else if (operatorA == "*")
            {
                sum = number1 * number2;
            }
            else if (operatorA == "+")
            {
                sum = number1 + number2;
            }
            else if (operatorA == "-")
            {
                sum = number1 - number2;
            }
            else
            {
                Console.WriteLine("Invalid Operator!");
            }
            Console.WriteLine(sum);
        }
    }
}
