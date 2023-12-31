﻿using System;

namespace _2._Еднакви_суми_на_четни_и_нечетни_позиции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата две шестцифрени цели
            // числа в диапазона от 100000 до 300000.Винаги първото въведено число
            // ще бъде по малко от второто.На конзолата да се отпечатат на 1 ред
            // разделени с интервал всички числа, които се намират между двете,
            // прочетени от конзолата числа и отговарят на следното условие:

            // •	сумата от цифрите на четни и нечетни позиции да са равни.Ако няма
            // числа, отговарящи на условието на конзолата не се извежда резултат.

            
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string surrentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < surrentNum.Length; j++)
                {
                    int surrentDigit = int.Parse(surrentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += surrentDigit;
                    }
                    else
                    {
                        oddSum += surrentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
