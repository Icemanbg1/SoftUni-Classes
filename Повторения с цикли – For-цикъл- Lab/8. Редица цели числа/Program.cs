using System;

namespace _8._Редица_цели_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Напишете програма, която чете n на брой цели числа. Принтирайте
            //най-голямото и най-малкото число сред въведените.

            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
            //                      Примерен вход и изход
            //      вход        изход                        Вход        Изход
            //      5           Max number: 304              6           Max number: 1000
            //      10          Min number: 0                250         Min number: 0
            //      20                                       5
            //      304                                      2
            //      0                                        0
            //      50                                       100
            //                                               1000

        }
    }
}
