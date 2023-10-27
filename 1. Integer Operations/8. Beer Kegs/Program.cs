using System;
using System.Collections.Generic;
using System.Drawing;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program, which calculates the volume of n beer kegs. You will receive
            // in total 3 * n lines.Every three lines will hold information for a single keg.
            // First up is the model of the keg, after that is the radius of the keg, and lastly is
            // the height of the keg.

            // Calculate the volume using the following formula: π* r^2 * h.
            // In the end, print the model of the biggest keg.

            // Input
            int n = int.Parse(Console.ReadLine());
            string model = "";
            double radius = 0;
            int height = 0;
            double volume = 0;
            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                // You will receive 3 * n lines.Each group of lines will be on a new line:
                // • First – model – string
                model = Console.ReadLine();
                // • Second –radius – floating - point number
                radius = double.Parse(Console.ReadLine());
                // • Third – height – integer number
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;
                if  (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = model;
                }
                
            }
            Console.WriteLine(biggestKegModel);

            // Output

            // Print the model of the biggest keg.

            // Constraints
            // • n will be in the interval[1…10].
            // • The radius will be a floating-point number in the interval[1…3.402823E+38].
            // • The height will be an integer in the interval[1…2147483647].
        }
    }
}
