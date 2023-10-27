using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());

            double food1 = dog * 2.50;
            double food2 = cat * 4;

            double food3 = food1 +  food2;

            Console.WriteLine($"{food3} lv.");

        }
    }
}