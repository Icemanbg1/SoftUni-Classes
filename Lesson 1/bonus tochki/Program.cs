using System;

namespace bonus_tochki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startpoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (startpoints <= 100)
            {
                bonus = 5;
            }

            else if (startpoints > 100 && startpoints <= 1000)
            {
                bonus = startpoints * 0.2;
            }

            else
            {
                bonus = startpoints * 0.1; 
            }

            if (startpoints % 2 == 0) 
            {
                bonus += 1;
            }

            else if(startpoints % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + startpoints);
        }
    }
}
