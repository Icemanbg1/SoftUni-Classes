using System;

namespace _5._Поток_от_символи
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

           for (int i = 0; i < input.Length; i++)
           {
                Console.WriteLine(input[i]);
           }
        }
    }
}
