using System;

namespace zakruglenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}
