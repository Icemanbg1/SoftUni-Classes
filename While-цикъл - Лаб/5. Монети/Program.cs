using System;

namespace _5._Монети
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Производителите на вендинг машини искали да направят машините си да
            // връщат възможно най - малко монети ресто. Напишете програма, която
            // приема сума -рестото, което трябва да се върне и изчислява с колко
            // най-малко монети може да стане това.
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsCount = 0;
           
            while (change > 0)
            {
                if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }
                else if (change >= 0.5m)
                {
                    change -= 0.5m;
                }
                else if (change >= 0.2m)
                {
                    change -= 0.2m;
                }
                else if (change >= 0.1m)
                {
                    change -= 0.1m;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                }
                else
                {
                    change -= 0.01m;
                }
               
                coinsCount++;
            }
            Console.WriteLine(coinsCount);
        }
    }
}
