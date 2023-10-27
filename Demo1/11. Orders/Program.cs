using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double sumAll = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = pricePerCapsule * daysInMonth * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                sumAll += price;
            }
            Console.WriteLine($"Total: ${sumAll:f2}");
        }
    }
}
