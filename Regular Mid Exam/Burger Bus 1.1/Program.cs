using System;

namespace BurgerBus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string cityName = Console.ReadLine();
                decimal ownersIncome = decimal.Parse(Console.ReadLine());
                decimal ownersExpenses = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    ownersExpenses *= 1.5m; // Special event: 50% over costs
                }

                decimal profit = ownersIncome - ownersExpenses;

                if (i % 5 == 0)
                {
                    decimal rainyDayLoss = 0.1m * ownersIncome; // Rainy day: 10% loss from the income
                    profit -= rainyDayLoss;
                }

                totalProfit += profit;

                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}