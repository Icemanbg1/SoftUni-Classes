using System;

namespace Exer._1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A train has n number of wagons(integer, received as input).On the next n lines,
            // you will receive the number of people that are going to get on each wagon.
            // Print out the number of passengers in each wagon followed by the total number of passengers
            // on the train.    
            int n = int.Parse(Console.ReadLine());
            int numPeople = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numPeople = int.Parse(Console.ReadLine());
                sum += numPeople;
            }

            Console.WriteLine(string.Join(" ", numPeople));
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
