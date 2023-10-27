using System;

namespace nov_dom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята,
            // че Ви убеждава да напишете програма която да изчисли колко  ще им струва, да си
            // засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя
            // са с различни цени. 

            // цвете                   Роза      Далия       Лале       Нарцис       Гладиола
            // Цена на брой в лева       5        3.80       2.80          3           2.50

            // От конзолата се четат 3 реда:
            // •	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
                    string flowers = Console.ReadLine();
            // •	Брой цветя -цяло число в интервала[10…1000]
                    int flowercount = int.Parse(Console.ReadLine());
            // •	Бюджет - цяло число в интервала[50…2500]
                    int budget = int.Parse(Console.ReadLine());

                    // Съществуват следните отстъпки:
                    // •	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
                    if (flowers == "Roses")
                    {
                        double Roses = 5.00;
                        if (flowercount > 80)
                        {
                            double sum = Roses * flowercount;
                            double total = sum * 0.9;
                            if (budget >= total)
                            {
                                Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                                  $" {flowers} and {budget - total:f2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
                            }
                        }
                        else
                        {
                            double sum = Roses * flowercount;
                            if (budget >= sum)
                            {
                                Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                                  $" {flowers} and {budget - sum:f2} leva left.");
                            }
                            else
                            {
                                Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                            }
                        }
                    }
            // •	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            if (flowers == "Dahlias")
            {
                double Dahlias = 3.80;
                if (flowercount > 90)
                {
                    double sum = Dahlias * flowercount;
                    double total = sum * 0.85;
                    if (budget >= total)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - total:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = Dahlias * flowercount;
                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            // •	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            if (flowers == "Tulips")
            {
                double Tulips = 2.80;
                if (flowercount > 80)
                {
                    double sum = Tulips * flowercount;
                    double total = sum * 0.85;
                    if (budget >= total)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - total:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = Tulips * flowercount;
                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }

            // •	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            if (flowers == "Narcissus")
            {
                double Narcissus = 3.00;
                if (flowercount < 120)
                {
                    double sum = Narcissus * flowercount;
                    double total = sum * 1.15;
                    if (budget >= total)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - total:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = Narcissus * flowercount;
                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            // •	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            if (flowers == "Gladiolus")
            {
                double Gladiolus = 2.50;
                if (flowercount < 80)
                {
                    double sum = Gladiolus * flowercount;
                    double total = sum * 1.20;
                    if (budget >= total)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - total:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = Gladiolus * flowercount;
                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowercount}" +
                                          $" {flowers} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }



            // Да се отпечата на конзолата на един ред:
            // •	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} 
            //      {вид цветя} and {останалата сума} leva left."
            // •	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."

            // Сумата да бъде форматирана до втория знак след десетичната запетая.

        }
    }
}
