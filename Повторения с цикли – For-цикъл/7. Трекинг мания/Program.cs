
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace _7._Трекинг_мания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            double allPeople = 0;
            for (double i = 0; i <groupsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                if (peopleCount <= 5)
                {
                    musala += 1 * peopleCount;
                }
                else if (peopleCount >= 6 && peopleCount <= 12)
                {
                    monblan += 1 * peopleCount;
                }
                else if (peopleCount >= 13 && peopleCount <= 25)
                {
                    kilimanjaro += 1 * peopleCount;
                }
                else if (peopleCount >= 26 && peopleCount <= 40)
                {
                    k2 += 1 * peopleCount;
                }
                else
                {
                    everest += 1 * peopleCount;
                }

            }
            allPeople = musala + monblan + kilimanjaro + k2 + everest;

            Console.WriteLine($"{musala / allPeople * 100:f2}%");
            Console.WriteLine($"{monblan / allPeople * 100:f2}%");
            Console.WriteLine($"{kilimanjaro / allPeople * 100:f2}%");
            Console.WriteLine($"{k2 / allPeople * 100:f2}%");
            Console.WriteLine($"{everest / allPeople * 100:f2}%");

        }
    }
}
