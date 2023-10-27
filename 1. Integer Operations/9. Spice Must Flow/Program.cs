using System;

namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int days = 0;
            int spice = 0;

            while (yeld >= 100)
            {
                days++;
                spice += yeld;
                spice -= 26;
                yeld -= 10;
            }

            spice -= 26;
            
            if (spice < 0)
            {
                spice = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
