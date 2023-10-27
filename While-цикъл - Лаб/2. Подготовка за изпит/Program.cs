using System;

namespace _2._Подготовка_за_изпит
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorScores = int.Parse(Console.ReadLine());
            string taskName = "";
            int score = 0;
            int count = 0;
            int n = 0;
            double scoreSum = 0;
            bool isFailed = true;
            string lastTask = "";

            while (n < poorScores)
            {
                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                score = int.Parse(Console.ReadLine());
                if (score <= 4)
                {
                    n++;
                }
                count++;
                scoreSum += score;
                lastTask = taskName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {n} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {scoreSum/count:f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}