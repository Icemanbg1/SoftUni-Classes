using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You are going to receive two lists of numbers.Create a list that contains
            // the numbers from both of the lists. The first element should be from the
            // first list, the second from the second list, and so on.If the length of the
            // two lists is not equal, just add the remaining elements at the end of the list.

            List<int> number1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> number2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> num1Num2 = new List<int>();

            int iterations = Math.Max(number1.Count, number2.Count);

            for (int i = 0; i < iterations; i++)
            {
                if (i < number1.Count)
                {
                    num1Num2.Add(number1[i]);
                }

                if (i < number2.Count)
                {
                    num1Num2.Add(number2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", num1Num2));
        }
    }
}
