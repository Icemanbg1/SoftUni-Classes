using System;

namespace godzila_vs._king_kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 5.Годзила срещу Конг
                               
           // Вход
           // От конзолата се четат 3 реда:

           // Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
           double budget = double.Parse(Console.ReadLine());

           // Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
           int statists = int.Parse(Console.ReadLine());

           // Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
           double clothes = double.Parse(Console.ReadLine());
            
           // •	Декорът за филма е на стойност 10 % от бюджета.
           double decor = budget * 0.1;

            double allclothes = statists * clothes;

            // •	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            if (statists > 150) 
            {
                allclothes *= 0.9;
            }

            // Изход
            // На конзолата трябва да се отпечатат два реда:

            // •	Ако парите за декора и дрехите са повече от бюджета:
            // o   "Not enough money!"
            // o   "Wingard needs {парите недостигащи за филма} leva more."
            double neededmoney = allclothes + decor;
           if (neededmoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededmoney - budget:f2} leva more.");
            }

           // •	Ако парите за декора и дрехите са по малко или равни на бюджета:
           // o   "Action!"
           // o   "Wingard starts filming with {останалите пари} leva left."
           // Резултатът трябва да е форматиран до втория знак след десетичната запетая.
           else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - neededmoney:f2} leva left.");
            }


        }
    }
}
