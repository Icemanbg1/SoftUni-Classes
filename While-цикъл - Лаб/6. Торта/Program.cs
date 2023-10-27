using System;

namespace _6._Торта
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поканени сте на 30 - ти рожден ден, на който рожденикът черпи
            // с огромна торта. Той обаче не знае колко парчета могат да си
            // вземат гостите от нея.Вашата задача е да напишете програма, която
            // изчислява броя на парчетата, които гостите са взели, преди тя да свърши.
            // Ще получите размерите на тортата

            // (широчина и дължина – цели числа в интервала[1...1000])
            int pcsWight = int.Parse(Console.ReadLine());
            int pcsHeight = int.Parse(Console.ReadLine());
            int allPcs = pcsWight * pcsHeight;
            string input = "";
            // след това на всеки ред , до получаване на командата "STOP" или
            // докато не свърши тортата, броят на парчетата, които гостите вземат от нея.
            while (true)
            {
                input = Console.ReadLine(); 
                if (input == "STOP")
                {
                    break;
                }
                allPcs -= int.Parse(input);
                if (allPcs <= 0)
                {
                    break;
                }
            }
            if (allPcs <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allPcs)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{allPcs} pieces are left.");
            }

            // Бележка: Едно парче торта е с размер 1х1 см.

            // Да се отпечата на конзолата един от следните редове:
            // •	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            // •	"No more cake left! You need {брой недостигащи парчета} pieces more."

        }
    }
}
