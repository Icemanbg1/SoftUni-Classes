﻿using System;

namespace _3._Хистограма
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дадени са n цели числа в интервала[1…1000].От тях някакъв процент p1 са
            // под 200, друг процент p2 са от 200 до 399, друг процент p3 са от 400 до 599,
            // друг процент p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре.
            // Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.

            //   Вход
            // На първия ред от входа стои цялото число n(1 ≤ n ≤ 1000) – брой числа.
            double n = double.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            // На следващите n реда стои по едно цяло число в интервала[1…1000] – числата
            // върху които да бъде изчислена хистограмата.
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if (num >= 200 && num < 400 )
                {
                    p2 += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    p3 += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }

            //    Изход
            //    Да се отпечата на конзолата хистограмата – 5 реда, всеки от които
            // съдържа число между 0 % и 100 %, с точност две цифри след десетичната точка,
            // например 25.00 %, 66.67 %, 57.14 %.

            Console.WriteLine($"{(p1 / n) * 100:f2}%");
            Console.WriteLine($"{(p2 / n) * 100:f2}%");
            Console.WriteLine($"{(p3 / n) * 100:f2}%");
            Console.WriteLine($"{(p4 / n) * 100:f2}%");
            Console.WriteLine($"{(p5 / n) * 100:f2}%");


        }
    }
}
