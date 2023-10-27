using System;

namespace _4._Стъпки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Габи иска да започне здравословен начин на живот и си е поставила
            // за цел да върви 10 000 стъпки всеки ден.Някои дни обаче е много уморена
            // от работа и ще иска да се прибере преди да постигне целта си.
            int goalSteps = 10_000;
            int steps = 0;
            int sumSteps = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                steps += int.Parse(input);
               
                if (steps >= goalSteps)
                {
                    break;
                }

            }
            if (steps >= goalSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{(steps - goalSteps)} steps over the goal!");
                
            }
            else if (steps <= goalSteps)
                Console.WriteLine($"{Math.Abs(steps - goalSteps)} more steps to reach goal.");
            // Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път
            // като излиза през деня и когато постигне целта си да се изписва
            // "Goal reached! Good job!"  и колко стъпки повече е извървяла
            // "{разликата между стъпките} steps over the goal!"

            // Ако иска да се прибере преди това, тя ще въведе командата "Going home"
            // и ще въведе стъпките, които е извървяла докато се прибира.След което, ако
            // не е успяла да постигне целта си, на конзолата трябва да се изпише:
            // "{разликата между стъпките} more steps to reach goal."

        }
    }
}
