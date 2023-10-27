using System;

namespace Задача_1._Калкулатор_за_сериали
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която изчислява колко време ще ви отнеме да изгледате
            // всички епизоди на един сериал в минути.Ще разполагате с брой сезони, брой
            // епизоди на сезон и времетраене на един епизод.Във всеки епизод има реклами,
            // които са с продължителност 20 % от времето на един епизод. Също така знаете,
            // че всеки сезон завършва със специален епизод, който е с 10м по-дълъг от обичайното. 

            // Вход
            // От конзолата се четат 4 реда:
            // 1.Име на сериал -текст
            string name = Console.ReadLine();
            // 2.Брой сезони – цяло число в диапазона[1… 10]
            int seassonCount = int.Parse(Console.ReadLine());
            // 3.Брой епизоди  – цяло число в диапазона[10… 80]
            int seriesCount = int.Parse(Console.ReadLine());
            // 4.Времетраене на обикновен епизод без рекламите – реално число в диапазона[40.0… 65.0]
            double timeAll = double.Parse(Console.ReadLine());

            double commersial = timeAll * 0.2;
            double all = commersial + timeAll;
            int speshialSetiers = seassonCount * 10;
            double allTimeToWatch = all * seassonCount * seriesCount + speshialSetiers;



            // Изход
            // Да се отпечата на конзолата времето, необходимо за изглеждане на всички епизоди,
            // закръглено до най-близкото цяло число надолу в следния формат:
            // "Total time needed to watch the {име на сериал} series is {време} minutes."
            Console.WriteLine($"Total time needed to watch the {name} series is {allTimeToWatch} minutes."
);

        }
    }
}
