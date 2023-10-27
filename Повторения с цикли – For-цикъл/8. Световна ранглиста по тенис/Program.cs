using System;
using System.ComponentModel.Design;

namespace _8._Световна_ранглиста_по_тенис
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournamentCount = double.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double win = 0;
            double average = 0;
            int tournamentPoints = 0;
            double allPoints = 0;

            for (int i = 0; i < tournamentCount; i++)
            {
                string reachedStage = Console.ReadLine();
                if (reachedStage == "W") 
                {
                    tournamentPoints += 2000;
                    win++;
                }
                else if (reachedStage == "F")
                {
                    tournamentPoints += 1200;
                }
                else if (reachedStage == "SF") 
                {
                    tournamentPoints += 720;
                }


            }

            allPoints = tournamentPoints + startPoints;
            average = tournamentPoints / tournamentCount;
            average = Math.Floor(average);
            win = win / tournamentCount * 100;

            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{win:f2}%");
        }
    }
}
