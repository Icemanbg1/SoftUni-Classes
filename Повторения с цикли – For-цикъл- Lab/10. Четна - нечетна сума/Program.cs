using System;

namespace _10._Четна___нечетна_сума
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която чете n-на брой цели числа,
            // подадени от потребителя и проверява дали сумата от числата на четни
            // позиции е равна на сумата на числата на нечетни позиции.
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + int.Parse(Console.ReadLine());
                }
                else
                {
                    odd = odd + int.Parse(Console.ReadLine());
                }

            }

            //    •	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
            //    •	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата.
            //    Разликата се изчислява по абсолютна стойност. 

            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                int diff = Math.Abs(even - odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
