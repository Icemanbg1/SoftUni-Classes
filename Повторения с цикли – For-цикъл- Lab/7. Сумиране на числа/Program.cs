using System;

namespace _7._Сумиране_на_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем n от консзолата
            int n = int.Parse(Console.ReadLine());

            //2. Създаваме променлива, която да пази сумата на всички числа
            int sum = 0;

            //3. Създаваме цикъл, който да се изпълнява n на брой пъти
            for (int i = 1; i <= n; i += 1)
            {
                // => Четем число от конзолата
                int num = int.Parse(Console.ReadLine());

                // => Добавяме число към сумата на всички числа
                sum += num;
            }

            // 4. Извеждаме резултата на конзолата
            Console.WriteLine(sum);
        }
    }
}
