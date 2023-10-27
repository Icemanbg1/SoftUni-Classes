using System;

namespace absoliutna_stoinost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = a - b;
            Console.WriteLine(Math.Abs(result));
        }
    }
}
