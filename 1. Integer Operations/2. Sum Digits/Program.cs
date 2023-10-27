
using System;
using System.Linq;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = s.Select(x => int.Parse(x.ToString())).Sum();
            Console.WriteLine(result);
        }
    }
}
