using System;

namespace _4._Сума_от_две_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма която проверява всички възможни комбинации от двойка
            // числа в интервала от две дадени числа. На изхода се отпечатва, коя поред
            // е комбинацията чиито сбор от числата е равен на дадено магическо число.
            // Ако няма нито една комбинация отговаряща на условието се отпечатва съобщение,
            // че не е намерено.

            // Вход

            // Входът се чете от конзолата и се състои от три реда:
            // •	Първи ред – начало на интервала – цяло число в интервала[1...999]
            int startNum = int.Parse(Console.ReadLine());
            // •	Втори ред – край на интервала – цяло число в интервала[по - голямо от първото число...1000]
            int endNum = int.Parse(Console.ReadLine());
            // •	Трети ред – магическото число – цяло число в интервала[1...10000]
            int magicNum = int.Parse(Console.ReadLine());
            int result = 0;
            int count = 0;
            bool isValid = false;
            
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    result = i + j;
                    count++;
                    if (result == magicNum)
                    {
                        isValid = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }
            }
            if (!isValid)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }

            // Изход

            // На конзолата трябва да се отпечата един ред, според резултата:
            // •	Ако е намерена комбинация чиито сбор на числата е равен на магическото число
            // o   "Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
            // •	Ако не е намерена комбинация отговаряща на условието
            // o   "{броят на всички комбинации} combinations - neither equals {магическото число}"

        }
    }
}
