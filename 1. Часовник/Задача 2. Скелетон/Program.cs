using System;

namespace Задача_2._Скелетон
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Българският състезател по скелетон Марин Бангиев се бори за олимпийска
            // квота.Вие имате честта да напишете програмата, която ще изчисли дали той печели квота.  
            // Вашата програма получава контролата в минути, която трябва да бъде достигната или
            // подобрена, за да може Марин да вземе квота. Също така програмата ще получи разстоянието
            // на улея в метри, и времето в секунди, за което той изминава 100 метра.
            // Трябва да се има предвид, че поради наклона на улея, на всеки 120 метра неговото време
            // намаля с 2.5 секунди.

            // Вход
            // От конзолата се четат 4 реда:

            // 1.Минути на контролата – цяло число в интервала[0…59]
            int controlMin = int.Parse(Console.ReadLine());

            // 2.Секунди на контролата – цяло число в интервала[0…59]
            int controlSec = int.Parse(Console.ReadLine());

            // 3.Дължината на улея в метри – реално число в интервала[0.00…50000]
            double lenght = double.Parse(Console.ReadLine());

            // 4.Секунди за изминаване на 100 метра – цяло число в интервала[0…1000]
            double sec_100 = double.Parse(Console.ReadLine());

            int controlAll = controlMin * 60 + controlSec;

            double redusedTime = (lenght / 120) * 2.5;

            double marinTime = (lenght / 100) * sec_100 - redusedTime;
 

            // Изход
            // На конзолата трябва да се отпечата на един или два реда:
            // •	Ако времето на Марин е по-малко или равно на контролата:
            // o   "Marin Bangiev won an Olympic quota!"
            // o   "His time is {времето на Марин в секунди}."

            if (controlAll >= marinTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            // •	Ако времето на Марин е повече от това на контролата:
            // o    "No, Marin failed! He was {недостигащи секунди} second slower."
            // Резултатът трябва да е форматиран до третия знак след десетичния знак.
            else
            {
                Console.WriteLine($"No, Marin failed! He was {marinTime - controlAll:f3} second slower.");
            }

        }
    }
}
