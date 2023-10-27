using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives two parameters:
            //    • A string
            //    • A number n(integer) represents how many times the string will be repeated
            //The method should return a new string, containing the initial one, repeated n times without space. 
            string index = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Repeat(index, n);
        }

        static void Repeat(string index, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(index);
            }
        }
    }
}
