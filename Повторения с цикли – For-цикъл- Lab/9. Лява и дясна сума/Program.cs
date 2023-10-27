using System;

namespace _9._Лява_и_дясна_сума
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която чете 2 * n - на брой цели числа,
            // подадени от потребителя, и проверява дали сумата на първите n числа(лява сума)
            // е равна на сумата на вторите n числа(дясна сума). При равенство печата
            // " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.Разликата се изчислява
            // като положително число(по абсолютна стойност).
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 1; i <= n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = " + leftSum);
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = " + diff);
            }
        }
    }
}
