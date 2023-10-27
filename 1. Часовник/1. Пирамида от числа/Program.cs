using System;

namespace _1._Пирамида_от_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете цяло число n, въведено от потребителя,
            // и отпечатва пирамида от числа като в примерите
            int n = int.Parse(Console.ReadLine());
            int printRows = 1;

            for (int i = 0; i < n;)
            {
                for (int j = 0; j < printRows; j++)
                {
                    i++;
                    Console.Write(i + " ");
                    if (i == n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                printRows++;
            }
        }
    }
}
