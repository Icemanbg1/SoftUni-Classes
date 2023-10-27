using System;

namespace DemoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0.0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {money:F2}");
                sum = sum + money;
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}