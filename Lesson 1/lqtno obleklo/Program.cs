using System;

namespace lqtno_obleklo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Лятно облекло

            // Лято е с много променливо време и Виктор има нужда от вашата помощ. Напишете
            // програма която спрямо времето от денонощието и градусите да препоръча на Виктор
            // какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от
            // деня, които изискват и различен външен вид, тях може да видите от таблицата.

            // От конзолата се четат точно два реда:
            // •	Градусите - цяло число в интервала[10…42]
            // •	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (degrees >= 10 && degrees <= 18)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }

            else if (degrees > 18 && degrees <= 24)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }

            else if (degrees >= 25)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }

            // Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."

        }
    }
}
