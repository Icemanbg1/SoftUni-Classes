using System;

namespace zakruglenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"{ num:f2} leva");
        }
    }
}
