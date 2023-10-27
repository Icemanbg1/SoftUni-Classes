using System;

namespace Regular_Mid_Exam
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfTheCity = Console.ReadLine();
                decimal ownersIncome = decimal.Parse(Console.ReadLine());
                decimal ownersExpenses = decimal.Parse(Console.ReadLine());


                if (i % 3 == 0)
                {
                    ownersExpenses *= 1.5m;
                }

                else if (i % 5 == 0)
                {
                    ownersIncome *= 0.9m;
                }

                decimal profit = ownersIncome - ownersExpenses;

                totalProfit += profit;

                Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {profit:f2} leva.");

                

            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
