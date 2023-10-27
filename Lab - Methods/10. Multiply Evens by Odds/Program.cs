using System;

namespace _09.Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            n = Math.Abs(n);
            int sumEvens = GetSumOfEvens(n);
            int sumOdds = GetSumOfOdds(n);
            return sumEvens * sumOdds;
        }

        static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                    sum += lastDigit;
                n /= 10;
            }

            return sum;
        }

        static int GetSumOfOdds(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                    sum += lastDigit;
                n /= 10;
            }

            return sum;
        }
    }
}