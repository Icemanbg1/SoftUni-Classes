using System;
using System.Collections.Generic;

using static System.Net.Mime.MediaTypeNames;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will receive N – an integer, the number of snowballs being made by Tony and Andi.
            int snowBalls = int.Parse(Console.ReadLine());
            double snowBallValue = 0;
            double maxSnowBallValue = double.MinValue;
            int snowBallSnow = 0;
            int endSnowBallSnow = 0;
            int snowBallTime = 0;
            int endSnowBallTime = 0;
            int snowBallQuality = 0;
            int endSnowBallQuality = 0;
            // For each snowball you will receive 3 input lines:
            for (int i = 0; i < snowBalls; i++)
            {
                // • On the first line, you will get the snowballSnow – an integer.
                snowBallSnow = int.Parse(Console.ReadLine());
                // • On the second line you will get the snowballTime – an integer.
                snowBallTime = int.Parse(Console.ReadLine());
                // • On the third line, you will get the snowballQuality – an integer.
                snowBallQuality = int.Parse(Console.ReadLine());
                // For each snowball you must calculate its snowballValue by the following formula:
                // (snowballSnow / snowballTime) ^ snowballQuality
                snowBallValue = Math.Pow(snowBallSnow / snowBallTime, snowBallQuality);
                if (snowBallValue > maxSnowBallValue)
                {
                    maxSnowBallValue = snowBallValue;
                    endSnowBallSnow = snowBallSnow;
                    endSnowBallTime = snowBallTime;
                    endSnowBallQuality = snowBallQuality;
                }
                
            }

            // In the end, you must print the highest calculated snowballValue.

            // Output
            // • As output, you must print the highest calculated snowballValue, by the formula, specified above.
            // • The output format is:
            // { snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})
            Console.WriteLine($"{endSnowBallSnow} : {endSnowBallTime} = {maxSnowBallValue} ({endSnowBallQuality})");

            // Constraints
            // • The number of snowballs(N) will be an integer in the range[0…100].
            // • The snowballSnow is an integer in the range[0…1000].
            // • The snowballTime is an integer in the range[1…500].
            // • The snowballQuality is an integer in the range[0…100].
            // • Allowed working time / memory: 100ms / 16MB.
        }
    }
}
