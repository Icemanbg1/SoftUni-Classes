using System;

namespace _4._Редица_числа_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете число n, въведено от потребителя,
            // и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. Всяко
            // следващо число се изчислява като умножим предишното с 2 и добавим 1.
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i = i * 2 + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
