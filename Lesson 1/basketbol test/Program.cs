using System;

namespace basketbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yeartax = double.Parse(Console.ReadLine());

            double sneakers = yeartax - (yeartax * 0.4);
            Console.WriteLine(sneakers);
            double outfit = sneakers - (sneakers * 0.2);
            Console.WriteLine(outfit);
            double ball = outfit * 0.25;
            Console.WriteLine(ball);
            double acc = ball * 0.2;
            Console.WriteLine(acc);

            double all = yeartax + sneakers + ball + acc;
            Console.WriteLine(all);
        }
    }
}
