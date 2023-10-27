using System;

namespace puteshestvie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.Пътешествие

            // Вход

            // Входът се чете от конзолата и се състои от два реда, въведени от потребителя:
            // •	Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            double budget = double.Parse(Console.ReadLine());
            // •	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            string seasson = Console.ReadLine();

            // Напишете програма,
            // която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива
            // програмиста и колко ще похарчи.

            // Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи.
            // Ако е лято ще почива на къмпинг.

            // Зимата в хотел.
            // Ако е в Европа,независимо от сезона ще почива в хотел.
            // Всеки къмпинг или хотел, според дестинацията, има собствена цена
            // която отговаря на даден процент от бюджета: 

            // •	При 100лв.или по-малко – някъде в България
            // o   Лято – 30 % от бюджета
            // o   Зима – 70 % от бюджета
            if (budget <= 100)
            {
                if (seasson == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget * 0.3:f2}");
                }
                else if (seasson == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.7:f2}");
                }
            }

            // •	При 1000лв.или по малко – някъде на Балканите
            // o   Лято – 40 % от бюджета
            // o   Зима – 80 % от бюджета
            else if (budget <= 1000)
            {
                if (seasson == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.4:f2}");
                }
                else if (seasson == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.8:f2}");
                }
            }

            // •	При повече от 1000лв. – някъде из Европа
            // o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            if (budget > 1000)
            {
                
                Console.WriteLine("Somewhere in Europe"); 
                Console.WriteLine($"Hotel - {budget * 0.9:f2}");
                
            }

            // Изход
            // На конзолата трябва да се отпечатат два реда.
            // •	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            // •	Втори ред – “{ Вид почивка} – { Похарчена сума}“
            // o Почивката може да е между „Camp” и „Hotel”
            // o Сумата трябва да е закръглена с точност до вторият знак след запетаята.

        }
    }
}
