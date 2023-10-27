using System;

namespace Задача_3._Боядисване_на_яйца
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Линк към Judge: https://judge.softuni.bg/Contests/Practice/Index/1637#5

            //С наближаването на Великденските празници, цех за боядисване на яйца, започва
            //да боядисва различни размери яйца, които след това продава на партиди.В таблицата
            //са показани размерите на яйцата, различните бои и каква е цената за продажба на
            //една партида яйца, зависеща от размерите и цвета боя.

            //                Червено(Red)       Зелено(Green)       Жълто(Yellow)
            //Големи(Large)      16 лв.              12 лв.               9 лв.
            //Средни(Medium)     13 лв.               9 лв.               7 лв.
            //Малки(Small)        9 лв.               8 лв.               5 лв.

            //Напишете програма, която изчислява какви ще са приходите на цеха от продажбите,
            //като знаете размера на яйцата и техният цвят. С 35 % от крайната цена ще бъдат
            //покрити производствени разходи.

            // Вход

            // Входът се чете от конзолата и се състои от три реда:
            // •	Първи ред – размер на яйцата – текст с възможности "Large", "Medium" или "Small"
            string size = Console.ReadLine();
            // •	Втори ред – цвят на яйцата – текст с възможности "Red", "Green" или "Yellow"
            string color = Console.ReadLine();
            // •	Трети ред – брой партиди – цяло число в интервала[1… 350]
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            double price = 0;
            double expences = 0;

            if (size == "Large")
            {
                if (color == "Red")
                {
                    sum = 16;
                }
                else if (color == "Green")
                {
                    sum = 12;
                }
                else if (color == "Yellow")
                {
                    sum = 9;
                }
                else
                {
                    Console.WriteLine("Wrong Color!");
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    sum = 13;
                }
                else if (color == "Green")
                {
                    sum = 9;
                }
                else if (color == "Yellow")
                {
                    sum = 7;
                }
                else
                {
                    Console.WriteLine("Wrong Color!");
                }
            }
            else if (size == "Small")
            {
                if (color == "Red")
                {
                    sum = 9;
                }
                else if (color == "Green")
                {
                    sum = 8;
                }
                else if (color == "Yellow")
                {
                    sum = 5;
                }
                else
                {
                    Console.WriteLine("Wrong Color!");
                }
            }
            else
            {
                Console.WriteLine("Wrong Size!");
            }
            price = count * sum;
            expences = price * 0.35;
            price = price - expences;

            // Изход

            // На конзолата трябва да се отпечата един ред:
            //            "{крайната цена} leva."
            // Резултатът да се форматира до втората цифра след десетичния знак.

            Console.WriteLine($"{price:f2} leva.");


        }
    }
}
