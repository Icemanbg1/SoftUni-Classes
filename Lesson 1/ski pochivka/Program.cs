using System;

namespace ski_pochivka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9.Ски почивка

            // Вход

            // Входът се чете от конзолата и се състои от три реда:

            // •	Първи ред - дни за престой - цяло число в интервала[0...365]
            int vacationDays = int.Parse(Console.ReadLine()) - 1;
            // •	Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
            string roomType = Console.ReadLine();
            // •	Трети ред - оценка - "positive"  или "negative"
            string score = Console.ReadLine();

            // Изчисления

            // Атанас решава да прекара отпуската си в Банско и да кара ски.Преди да отиде
            // обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя.
            // Налични са следните видове помещения, със следните цени за престой:

            // 	"room for one person" – 18.00 лв за нощувка
            double room = 18.00;
            // 	"apartment" – 25.00 лв за нощувка
            double apartment = 25.00;
            // 	"president apartment" – 35.00 лв за нощувка
            double apartmentP = 35.00;

            // Според броят на дните, в които ще остане в хотела(пример: 11 дни = 10 нощувки)
            // и видът на помещението, което ще избере, той може да ползва различно намаление.

            // Намаленията са както следва:

            // вид помещение         по - малко от 10 дни         между 10 и 15 дни         повече от 15 дни
            // room for one person   не ползва намаление          не ползва намаление       не ползва намаление
            // apartment             30 % от крайната цена        35 % от крайната цена     50 % от крайната цена
            // president apartment   10 % от крайната цена        15 % от крайната цена     20 % от крайната цена
            if (vacationDays < 10)
            {
                apartment *= 0.70;
                apartmentP *= 0.90;
            }
            else if (vacationDays >= 10 && vacationDays <= 15)
            {
                apartment *= 0.65;
                apartmentP *= 0.85;
            }
            else if (vacationDays > 15)
            {
                apartment *= 0.50;
                apartmentP *= 0.80;
            }

            double roomCost = vacationDays * room;
            double apartmentCost = vacationDays * apartment;
            double apartmentPCost = vacationDays * apartmentP;
            // След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive)
            // или негативна(negative).Ако оценката му е позитивна, към цената с вече приспаднатото
            // намаление Атанас добавя 25 % от нея.Ако оценката му е негативна приспада от цената 10 %.
            if (score == "positive")
            {
                if (roomType == "room for one person")
                {
                    roomCost *= 1.25;
                    Console.WriteLine($"{roomCost:f2}");
                }
                else if (roomType == "apartment")
                {
                    apartmentCost *= 1.25;
                    Console.WriteLine($"{apartmentCost:f2}");
                }
                else if (roomType == "president apartment")
                {
                    apartmentPCost *= 1.25;
                    Console.WriteLine($"{apartmentPCost:f2}");
                }
            }
            else if (score == "negative")
            {
                if (roomType == "room for one person")
                {
                    roomCost *= 0.90;
                    Console.WriteLine($"{roomCost:f2}");
                }
                else if (roomType == "apartment")
                {
                    apartmentCost *= 0.90;
                    Console.WriteLine($"{apartmentCost:f2}");
                }
                else if (roomType == "president apartment")
                {
                    apartmentPCost *= 0.90;
                    Console.WriteLine($"{apartmentPCost:f2}");
                }
            }

            // Изход

            // На конзолата трябва да се отпечата един ред:
            // •	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.

        }
    }
}
