﻿using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double inch = a * 2.54;

            Console.WriteLine($"{inch} inch");

        }
    }
}