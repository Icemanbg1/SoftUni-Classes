using System;

namespace _6._Най_голямо_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която до получаване на командата "Stop",
            // чете цели числа, въведени от потребителя и намира най-голямото измежду тях.
            // Въвежда се по едно число на ред.
            string input = Console.ReadLine();
            int max = int.MinValue;
            

            while (input != "Stop")
            {
               int num = int.Parse(input);
                if (num > max)
                {
                    max = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
