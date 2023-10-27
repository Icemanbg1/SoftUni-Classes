using System;
using System.Threading.Channels;

namespace Exer._1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a method that prints out the smallest of three integer numbers.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallestNumber(a, b, c));

        }

        static int PrintSmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }

            else if (b < a && b < c)
            {
                return b;
            }

            else 
            {
                return c;

            }
        }
    }
}
