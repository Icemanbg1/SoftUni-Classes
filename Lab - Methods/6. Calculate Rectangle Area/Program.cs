using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calculations(a, b);

        }

        static void Calculations(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(c);
        }
    }
}
