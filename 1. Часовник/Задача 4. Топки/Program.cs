using System;

namespace Задача_4._Топки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Линк към Judge: https://judge.softuni.bg/Contests/Compete/Index/2507#3

            // В кутия имаме неопределен брой топки с различни цветове, които ни носят различен
            // брой точки. Задачата ни е да извадим Х бр.топки, които ще бъдат въведени от конзолата,
            // като се има в предвид, че всеки различен цвят влияе на точките ни по следния начин:
   
            // Вход
            // 1.От конзолата се чете 1 цяло число N, което е броят на топките в диапазон(0 - 1000).
            int ballCount = int.Parse(Console.ReadLine());
            double sum = 0;
            int red = 0;
            int yellow = 0;
            int orange = 0;
            int white = 0;
            int black = 0;
            int other = 0;
            // 2.След това се четат N на брой цветове.
            for (int i = 0; i < ballCount; i++)
            {
                string color = Console.ReadLine();
                // •	Ако топката е "red" точките ни се повишават с 5.
                if (color == "red")
                {
                    sum += 5;
                    red++;
                }
                // •	Ако топката е "orange" точките ни се повишават с 10.
                else if (color == "orange")
                {
                    sum += 10;
                    orange++;
                }
                // •	Ако топката е "yellow" точките ни се повишават с 15.
                else if (color == "yellow")
                {
                    sum += 15;
                    yellow++;
                }
                // •	Ако топката е "white" точките ни се повишават с 20.
                else if (color == "white")
                {
                    sum += 20;
                    white++;
                }
                // •	Ако топката е "black" точките ни се делят на 2(целочислено).
                else if (color == "black")
                {
                    sum /= 2;
                    black++;
                }
                // Ако топката е с какъвто и да е цвят, различен от по - горните, точките не се
                // манипулират и програмата продължава да работи.
                else
                {
                    other++;
                    continue;
                }
            }


            // Изход
            // Отпечатват се следните редове:
            // "Total points: {всичките събрани точки}"
            Console.WriteLine($"Total points: {(int)sum}");
            // "Red balls: {брой червени топки}"
            Console.WriteLine($"Red balls: {red}");
            // "Orange balls: {брой оранжеви топки}"
            Console.WriteLine($"Orange balls: {orange}");
            // "Yellow balls: {брой жълти топки}"
            Console.WriteLine($"Yellow balls: {yellow}");
            // "White balls: {брой бели топки}"
            Console.WriteLine($"White balls: {white}");
            // "Other colors picked: {броят на избраните топки извън зададените цветове}"
            Console.WriteLine($"Other colors picked: {other}");
            // "Divides from black balls: {броят на пътите, в които точките са били разделяни на 2}"
            Console.WriteLine($"Divides from black balls: {black}");

        }
    }
}
