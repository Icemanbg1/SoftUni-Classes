using System;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            bool isValid = a == b;
            Console.WriteLine(isValid);

            a = b;
            Console.WriteLine(isValid);

            isValid = a == b;
            Console.WriteLine(isValid);
        }
    }
}
