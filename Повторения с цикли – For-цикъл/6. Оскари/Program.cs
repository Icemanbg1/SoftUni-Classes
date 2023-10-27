using System;

namespace _6._Оскари
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < judgesCount; i++)
            {
                string name = Console.ReadLine();
                double judgesPoints = double.Parse(Console.ReadLine());

                academyPoints += (name.Length * judgesPoints) / 2;

                if (academyPoints > 1250.5)
                {
                    break;
                }
            }

            if (academyPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for " +
                                  $"leading role with {academyPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}
