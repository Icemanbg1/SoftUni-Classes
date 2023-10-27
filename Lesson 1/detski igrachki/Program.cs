using System;

namespace detski_igrachki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Цени на играчките:

            double puzzle = 2.60;
            double tDolls = 3;
            double teddy = 4.10;
            double minion = 8.20;
            double truck = 2;


            // 1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            double tripprize = double.Parse(Console.ReadLine());

            // 2.Брой пъзели - цяло число в интервала[0… 1000]
            int puzzlecount = int.Parse(Console.ReadLine());
          
            // 3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            int tDollscount = int.Parse(Console.ReadLine());


            // 4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            int teddycount = int.Parse(Console.ReadLine());

            // 5.Брой миньони - цяло число в интервала[0 … 1000]
            int minioncount = int.Parse(Console.ReadLine());

            // 6.Брой камиончета - цяло число в интервала[0 … 1000]
            int truckcount = int.Parse(Console.ReadLine());

            

            // Сума: 20 * 2.60 + 25 * 3 + 30 * 4.10 + 50 * 8.20 + 10 * 2 = 680 лв.
            double sum = puzzle * puzzlecount + tDolls * tDollscount + teddy * teddycount + minion * minioncount + truck * truckcount;

            // Брой на играчките: 20 + 25 + 30 + 50 + 10 = 135
            int alltoys = puzzlecount + tDollscount + minioncount + truckcount + teddycount;

            // Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25%
            // от общата цена. От спечелените пари Петя трябва да даде 10% за наема на магазина.
            // Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.

            // 135 > 50 => 25 % отстъпка; 25 % от 680 = 170 лв.отстъпка
            if (alltoys >= 50)
            {
                sum *= 0.75;
            }

            // Крайна цена: 680 – 170 = 510 лв.
            // Наем: 10 % от 510 лв. = 51 лв.
            // Печалба: 510 – 51 = 459 лв.
            sum *= 0.9;

            //  Ако парите са достатъчни се отпечатва:
            // o   "Yes! {оставащите пари} lv left."
            // Ако парите НЕ са достатъчни се отпечатва:
            // o   "Not enough money! {недостигащите пари} lv needed."
            // 459 > 40.8 => 459 – 40.8 = 418.20 лв.остават
            if (sum >= tripprize) 
            { 
                double money = sum - tripprize;
                Console.WriteLine($"Yes! {money:f2} lv left.");
            }

            else
            {
                double money = tripprize - sum;
                Console.WriteLine($"Not enough money! {money:f2} lv needed.");
            }








        }
    }
}
