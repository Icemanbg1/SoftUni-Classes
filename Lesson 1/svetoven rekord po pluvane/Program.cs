using System;
using System.IO;

namespace svetoven_rekord_po_pluvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.Световен рекорд по плуване

            // Вход
            // От конзолата се четат 3 реда:
            // 1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            double recordS = double.Parse(Console.ReadLine());

            // 2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double distanseM = double.Parse(Console.ReadLine());

            // 3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double timeS1m = double.Parse(Console.ReadLine());

            double time = distanseM * timeS1m;

            // Cъпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди
            double slowing = Math.Floor(distanseM / 15);
            double slowing1 = slowing * 12.5;
            double totaltime = time + slowing1;


            // резултатът трябва да се закръгли надолу до най - близкото цяло число.

            // Изход
            // Отпечатването на конзолата зависи от резултата:
            // •	Ако Иван е подобрил Световния рекорд(времето му е по-малко от рекорда) отпечатваме:
            // o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
            if (recordS > totaltime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totaltime:f2} seconds.");
            }
            // •	Ако НЕ е подобрил рекорда(времето му е по - голямо или равно на рекорда) отпечатваме:
            // o   "No, he failed! He was {недостигащите секунди} seconds slower."
            else
            {
                Console.WriteLine($"No, he failed! He was {totaltime - recordS:f2} seconds slower.");
            }
            // Резултатът трябва да се форматира до втория знак след десетичната запетая.

        }
    }
}
