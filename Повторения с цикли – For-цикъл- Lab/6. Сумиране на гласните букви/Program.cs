using System;
using System.Globalization;

namespace _6._Сумиране_на_гласните_букви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем вход от конзолата
            string input = Console.ReadLine();

            //2. Създаваме променлива, в която да пазим сумата на точките
            int sum = 0;

            //3. Създаваме цикъл, който да преминава през всеки елемент от текста
            for (int i = 0; i < input.Length; i++)
            {
                // => Взимамае елемента, до който сме стигнали и правим проверки за него
                char letter = input[i];
                switch (letter)
                {
                    // ==> a => +1
                    case 'a':
                        sum += 1;
                        break;
                    // ==> e => +2
                    case 'e':
                        sum += 2;
                        break;
                    // ==> i => +3
                    case 'i':
                        sum += 3;
                        break;
                    // ==> o => +4
                    case 'o':
                        sum += 4;
                        break;
                    // ==> u => +5
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;

                }
            }
            //4. Отпечватваме сумата на конзолата
            Console.WriteLine(sum);
        }
    }
}
