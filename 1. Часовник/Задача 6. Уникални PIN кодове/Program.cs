﻿using System;

namespace Задача_6._Уникални_PIN_кодове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която генерира трицифрени PIN кодове, като цифрите
            // на всеки PIN код са в определен интервал.За да бъде валиден един PIN код
            // той трябва да отговаря на следните условия:

            // •	Първата и третата цифра трябва да бъдат четни
            // •	Втората цифра трябва да бъде просто число в диапазона[2...7]


            // Вход:
            //        От конзолата се четат 3 реда:
            // •	Горната граница на първото число - цяло число в диапазона[1...9]
            int firstNum = int.Parse(Console.ReadLine());
            // •	Горната граница на второто число - цяло число в диапазона[1...9]
            double secondNum = double.Parse(Console.ReadLine());
            // •	Горната граница на третото число - цяло число в диапазона[1...9]
            int thirdNum = int.Parse(Console.ReadLine());


            for (int i = 2; i <= firstNum; i+=2)
            {
                for (int j = 2; j <= secondNum; j++)
                {
                    for (int k = 2; k <= thirdNum; k+=2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }

            // Изход:
            // Да се отпечатат на конзолата всички валидни трицифрени PIN кодове, чиито цифри
            // отговарят на съответните интервали.

        }
    }
}
