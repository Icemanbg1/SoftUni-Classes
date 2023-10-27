using System;
using System.Dynamic;

namespace obedna_pochivka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8.Обедна почивка


            //Вход

            //От конзолата се четат 3 реда:

            //  1.Име на сериал – текст
            string serial = Console.ReadLine();
        //  2.Продължителност на епизод  – цяло число в диапазона[10… 90]
        int time = int.Parse(Console.ReadLine());
        //  3.Продължителност на почивката  – цяло число в диапазона[10… 120]
        int break1 = int.Parse(Console.ReadLine());

            //Времето за обяд ще бъде 1 / 8 от времето за почивка, 
            double lunchtime = break1 * 0.125;
            //а времето за отдих ще бъде 1 / 4 от времето за почивка. 
            double breaktime = break1 * 0.25;
            double lefttime = break1 - lunchtime - breaktime;


            //Изход


            //На конзолата да се изпише един ред:

            //•	Ако времето е достатъчно да изгледате епизода:
            //    "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."

            if (lefttime >= time) 
            {
                Console.WriteLine($"You have enough time to watch {serial} " +
                    $"and left with {Math.Ceiling(lefttime - time)} minutes free time.");
            }

        //•	Ако времето не Ви е достатъчно:
        //    "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
        else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, " +
                    $"you need {Math.Ceiling(time - lefttime)} more minutes.");
            }

        //Времето да се закръгли до най-близкото цяло число нагоре.

        }
    }
}
