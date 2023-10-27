using System;

namespace Задача_2._Щанд_за_гривни
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Остават 5 дни до рождения ден на брата на Тереза. Тя иска да му купи подарък
            // и решава да си направи малък щанд и да продава плетени гривнички с мъниста,
            // за да събере достатъчно пари.
            // Вашата задача е да напишете програма, която да изчислява сумата, която Тереза
            // е успяла да събере и да даде отговор на момичето, дали тя ще може да купи подарък
            // или не. Трябва да се вземат предвид нейните разходи и цената на подаръка.

            // Вход
            // От конзолата се четат 4 реда:
            // •	Първи ред – джобните на Тереза на ден – реално число в интервала[1.00...100.00]
            double pocketMoney = double.Parse(Console.ReadLine()) * 5;
            // •	Втори ред – парите, които тя печели на ден от продажби – реално число в
            // интервала[1.00...1000.00]
            double profit = double.Parse(Console.ReadLine()) * 5;
            // •	Трети ред – разходите на Тереза за целия период – реално число в интервала[1.00...1000.00]
            double expenses = double.Parse(Console.ReadLine());
            // •	Четвърти ред – цената на подаръка – реално число в интервала[1.00...10000.00]
            double presentCost = double.Parse(Console.ReadLine());

            double allMoney = pocketMoney + profit;
            allMoney = allMoney - expenses;

            // Изход
            // На конзолата да се отпечата:
            // •	Ако са изработени достатъчно пари за подарък:
            // o   "Profit: {всички спестени пари} BGN, the gift has been purchased."
            // •	Ако са изработени по-малко нужните пари:
            // o   "Insufficient money: {сумата, която не достига} BGN."
            // Числата трябва да са форматирани до втория знак след десетичната запетая.
            if (allMoney >= presentCost)
            {
                Console.WriteLine($"Profit: {allMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {presentCost - allMoney:f2} BGN.");
            }

        }
    }
}
