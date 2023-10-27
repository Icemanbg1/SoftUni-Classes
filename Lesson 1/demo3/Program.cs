using System;

namespace demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b) 
                {
                    Console.WriteLine($"{a}<{b}");
                }
            if (a > b)  
                { 
                    Console.WriteLine($"{a}>{b}"); 
                }
            if (a ==  b) 
                {
                Console.WriteLine($"{a}={b}");
            }
        }
    }
}
