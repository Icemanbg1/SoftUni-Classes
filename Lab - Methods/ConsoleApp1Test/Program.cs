using System;

namespace ConsoleApp1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = a % 10;
            
            Console.WriteLine(sum);
        }
    }
}
