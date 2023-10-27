using System;

namespace basketbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yeartax = double.Parse(Console.ReadLine());

            double sneakers = yeartax - (yeartax * 0.4);
            double outfit = sneakers - (sneakers * 0.2);
            double ball = outfit * 0.25;
            double acc = ball * 0.2;

            double all = yeartax + sneakers + outfit + ball + acc;
            Console.WriteLine(all);
        }
    }
}
