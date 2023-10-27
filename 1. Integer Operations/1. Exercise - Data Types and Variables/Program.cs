using System;

namespace _1._Exercise___Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = first + second;
            int sum1 = sum / third;
            int sum2 = sum1 * fourth;
            Console.WriteLine(sum2);
        }
    }
}
