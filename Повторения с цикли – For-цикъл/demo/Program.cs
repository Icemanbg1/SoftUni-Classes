using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This code will add 10 to every odd year and add it to the next number.

            int year = 2023;

            while (year <= 2030)
            {
                if (year % 2 == 1)
                {
                    year += 10;
                }

                Console.WriteLine(year);

                year++;
            }
        }
    }
}
