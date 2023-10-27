using System;

namespace operacii_mejdu_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.Операции между числа

            //    Вход
            //    От конзолата се прочитат 3 реда, въведени от потребителя:
            //    •	N1 – цяло число в интервала[0...40 000]
            int N1 = int.Parse(Console.ReadLine());
            //    •	N2 – цяло число в интервала[0...40 000]
            double N2 = double.Parse(Console.ReadLine());
            //    •	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            char symbol = char.Parse(Console.ReadLine());


            // Напишете програма, която чете две цели числа(N1 и N2) и оператор,
            // с който да се извърши дадена математическа операция с тях.Възможните
            // операции са:
            // Събиране(+),
            if (symbol == '+')
            {
                double sum = N1 + N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {sum} - odd");
                }
            }
            // Изваждане(-),
            else if (symbol == '-')
            {
                double sum = N1 - N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {sum} - odd");
                }
            }
            // Умножение(*),
            else if (symbol == '*')
            {
                double sum = N1 * N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {sum} - odd");
                }
            }

            // Деление(/) и
            if (symbol == '/')
            {
                double sum = N1 / N2;
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} / {N2} = {sum:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

            }

            // Модулно деление(%).
            if (symbol == '%')
            {
                double sum = N1 % N2;
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} % {N2} = {sum}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }


                //    Изход
                //    Да се отпечата на конзолата един ред:
                //    •	Ако операцията е деление:
                //o   "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
                //    •	Ако операцията е модулно деление:
                //o   "{N1} % {N2} = {остатък}"
                //    •	В случай на деление с 0(нула): 
                //o   "Cannot divide {N1} by zero"

            }
        }

    }
}