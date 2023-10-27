using System;

namespace Задача_5._Грижи_за_кученце
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Линк към Judge: https://judge.softuni.bg/Contests/Practice/Index/2275#8

            // Ани намира кученце, за което ще се грижи, докато се намери някой да го
            // осинови.То изяжда дневно определено количество храна. Да се напише програма,
            // която проверява дали количеството храна, което е закупено за кученцето, ще е
            // достатъчно докато кученцето бъде осиновено.

            // Вход
            // От конзолата се прочитат:
            // •	Закупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            int allFood = int.Parse(Console.ReadLine()) * 1000;
            string input = "";
            int eatenFood = 0;
            int eatenFoodAll = 0;
            // •	На всеки следващ ред до получаване на команда Adopted ще получавате колко
            // грама изяжда кученцето на всяко хранене -цяло число в интервала[10 …1000]

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Adopted")
                {
                    break;
                }
                eatenFood = int.Parse(input);
                eatenFoodAll += eatenFood;
            }

            // Изход
            // На конзолата се отпечатва 1 ред:
            // •	Ако количеството храна е достатъчно да се отпечата:
            // "Food is enough! Leftovers: {останала храна} grams."
            if (allFood >= eatenFoodAll)
            {
                Console.WriteLine($"Food is enough! Leftovers: {allFood - eatenFoodAll} grams.");
            }

            // •	Ако количеството храна не е достатъчно да се отпечата:
            // "Food is not enough. You need {нужно количество храна} grams more."
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatenFoodAll - allFood} grams more.");
            }

        }
    }
}
