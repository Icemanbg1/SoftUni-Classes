using System;

namespace akvarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacity = lenght * wight * height;
            double capacityl = capacity / 1000;
            double space = percent / 100;

            double neededvolume = capacityl * (1 - space);
            Console.WriteLine(neededvolume);
        }
    }
}
