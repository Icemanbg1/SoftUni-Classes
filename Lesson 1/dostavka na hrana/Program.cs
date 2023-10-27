using System;

namespace dostavka_na_hrana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chiken = 10.35;
            double fish = 12.40;
            double vegi = 8.15;
            double delivery = 2.50;

            double chmeal = double.Parse(Console.ReadLine());
            double fmeal = double.Parse(Console.ReadLine());
            double vmeal = double.Parse(Console.ReadLine());

            double chprice = chiken * chmeal;
            double fprice = fish * fmeal;
            double vprice = vegi * vmeal;

            double allmeal = chprice + fprice + vprice;
            double desert = allmeal * 0.2;

            double all = allmeal + desert + delivery;

            Console.WriteLine(all);
        }
    }
}
