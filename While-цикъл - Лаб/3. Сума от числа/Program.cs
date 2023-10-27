using System;

namespace _3._Сума_от_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете цяло число от конзолата и на всеки следващ
            // ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното
            // число.След приключване да се отпечата сумата на въведените числа.

            int num = int.Parse(Console.ReadLine());
            int num1 = 0;

            while (num1 < num)
            {
                num1 += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(num1);
        }
    }
}
