using System;

namespace lodka_za_ribolov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.Лодка за риболов

            // Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
            // Вход
            // От конзолата се четат точно три реда.
            // •	Бюджет на групата – цяло число в интервала[1…8000]
            int budget = int.Parse(Console.ReadLine());
            // •	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            string seasson = Console.ReadLine();
            // •	Брой рибари – цяло число в интервала[4…18]
            int people = int.Parse(Console.ReadLine());

            // Цената зависи от сезона:
            // •	Цената за наем на кораба през пролетта е  3000 лв.
            // •	Цената за наем на кораба през лятото и есента е  4200 лв.
            // •	Цената за наем на кораба през зимата е  2600 лв.
            double rent = 0;
            switch (seasson)
            {
                case "Spring": rent = 3000; break;
                case "Summer": rent = 4200; break;
                case "Autumn": rent = 4200; break;
                case "Winter": rent = 2600; break;
            }

            double total = 0;
            // В зависимост от броя си групата ползва отстъпка:
            // •	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            if (people <= 6 && people > 0)
            {
                total = rent * 0.9;
            }
            // •	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            else if (people >= 7 && people <=11)
            {
                total = rent * 0.85;
            }
            // •	Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            else if (people > 11)
            {
                total = rent * 0.75;
            }

            // Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен -
            // тогава нямат допълнителна отстъпка, която се начислява след като се приспадне
            // отстъпката по горните критерии.
            int num = people % 2;
            if (num == 0 && seasson != "Autumn")
            {
                total = total * 0.95;
            }

            // Изход
            // Да се отпечата на конзолата един ред:
            // •	Ако бюджетът е достатъчен:
            // "Yes! You have {останалите пари} leva left."
            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            // •	Ако бюджетът НЕ Е достатъчен:
            // "Not enough money! You need {сумата, която не достига} leva."
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }
            // Сумите трябва да са форматирани с точност до два знака след десетичната запетая.

        }
    }
}
