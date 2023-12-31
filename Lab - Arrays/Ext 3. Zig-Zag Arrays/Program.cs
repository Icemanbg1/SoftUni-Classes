﻿using System;
using System.Globalization;

namespace Ext_3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFirstArrSelected = true;
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArray = numbers.Split();

                if (isFirstArrSelected)
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                else
                {
                    firstArr[i] = numbersArray[1];
                    secondArr[i] = numbersArray[0];
                }

                isFirstArrSelected = !isFirstArrSelected;
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));


        }
    }
}
