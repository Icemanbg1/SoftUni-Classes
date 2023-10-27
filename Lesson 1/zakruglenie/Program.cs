using System;

namespace zakruglenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            double up = Math.Ceiling(num);
            double down = Math.Floor(num);

            Console.WriteLine(up);
            Console.WriteLine(down);
        }
    }
}
