using System;

namespace hotelska_staq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7.Хотелска стая

            // Хотел предлага 2 вида стаи: студио и апартамент.Напишете програма,
            // която изчислява цената за целия престой за студио и апартамент.
            // Цените зависят от месеца на престоя:

            // Вход

            // Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
            // •	На първия ред е месецът – May, June, July, August, September или October
            string month = Console.ReadLine();
            // •	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            int nights = int.Parse(Console.ReadLine());

            // Изчисления

            // Май и октомври                   Юни и септември                     Юли и август
            // Студио – 50 лв./ нощувка         Студио – 75.20 лв./ нощувка         Студио – 76 лв./ нощувка
            // Апартамент – 65 лв./ нощувка     Апартамент – 68.70 лв./ нощувка     Апартамент – 77 лв./ нощувка
            double apartment = 0;
            double studio = 0;



            if (month == "May" || month == "October")
            {
                apartment = 65;
                studio = 50;
                // Предлагат се и следните отстъпки:
                // •	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
                if (nights > 14 && month == "May" || month == "October")
                {
                    studio *= 0.70;
                }
                // •	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
                else if (nights > 7 && month == "May" || month == "October")
                {
                    studio *= 0.95;
                }
               
            }

            else if (month == "June" || month == "September")
            {
                apartment = 68.70;
                studio = 75.20;
                // •	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
                if (nights > 14 && month == "June" || month == "September")
                {
                    studio *= 0.80;
                }
            }

            else if (month == "July" || month == "August")
            {
                apartment = 77;
                studio = 76;
            }

            // •	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            if (nights > 14)
            {
                apartment *= 0.90;
            }

            // Изход

            // Да се отпечатат на конзолата 2 реда:
            // •	На първия ред: “Apartment: { цена за целият престой} lv.”
            Console.WriteLine($"Apartment: {nights * apartment:f2} lv.");
            // •	На втория ред: “Studio: { цена за целият престой} lv.“
            Console.WriteLine($"Studio: {nights * studio:f2} lv.");
            // Цената за целия престой форматирана с точност до два знака след десетичната запетая.

        }
    }
}
