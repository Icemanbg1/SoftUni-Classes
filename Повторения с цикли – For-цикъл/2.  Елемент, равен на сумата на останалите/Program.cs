using System;

namespace _2.__Елемент__равен_на_сумата_на_останалите
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която чете n-на брой цели числа, въведени от
            // потребителя,и проверява дали сред тях съществува число, което е равно
            // на сумата на всички останали. 
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - (sum - max))}");
            }
            //    •	Ако има такъв елемент печата "Yes" и на нов ред "Sum = " + неговата стойност
            //    •	Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите(по абсолютна стойност)

        }
    }
}
