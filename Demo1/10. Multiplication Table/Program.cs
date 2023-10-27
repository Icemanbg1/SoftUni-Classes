using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++) 
            {
                sum = a * i;
                Console.WriteLine($"{a} X {i} = {sum}");
            }
        }
    }
}
