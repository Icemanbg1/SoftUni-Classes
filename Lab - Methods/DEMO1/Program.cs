using System;

namespace DEMO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(10, 20);
            Console.WriteLine();
            PrintNumbers(20, 30);
            Console.WriteLine();
            PrintNumbers(30, 40);
            Console.WriteLine();
        }

        static void PrintNumbers(int startNumber, int endNumbers) // zadavane na parametri na metod
        {
            for (int i = startNumber; i <= endNumbers; i++)
                Console.Write($"{i} ");
        }
    }
}
