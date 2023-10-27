using System;

namespace _4._Умната_Лили
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Вход
            //    Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
            //    •	Възрастта на Лили - цяло число в интервала[1...77]
            int age = int.Parse(Console.ReadLine());
            //    •	Цената на пералнята - число в интервала[1.00...10 000.00]
            double washPrice = double.Parse(Console.ReadLine());
            //    •	Единична цена на играчка -цяло число в интервала[0...40]
            int toyCost = int.Parse(Console.ReadLine());

            //    Лили вече е на N години. За всеки свой рожден ден тя получава подарък.
            //    
            //    •	За нечетните рождени дни(1, 3, 5...n) получава играчки.
            int toy = 0;
            //    •	За четните рождени дни(2, 4, 6...n) получава пари. 
            int money = 0;
            int m = 0;
            int n = 0;
            double total = 0;
            double change = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    m += 10;
                    money = money + m;
                    n++;
                }
                else
                {
                    toy++;
                }

            }
            total = (toy * toyCost) + (money - n);
            if (washPrice <= total)
            {
                change = total - washPrice;
                Console.WriteLine($"Yes! {change:f2}");
            }
            else
            {
                change = washPrice - total;
                Console.WriteLine($"No! {change:f2}");
            }
        }
    }
}
