using System;

namespace While_цикъл___Лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
