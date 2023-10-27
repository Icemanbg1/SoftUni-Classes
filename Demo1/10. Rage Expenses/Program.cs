using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            //You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming
            //equipment.

            //Input / Constraints

            //• On the first input line – lost games count – integer in the range[0…1000].
            int lostGames = int.Parse(Console.ReadLine());

            //• On the second line – headset price – floating - point number in the range[0…1000].
            double headsetPrice = double.Parse(Console.ReadLine());

            //• On the third line – mouse price – floating - point number in the range[0…1000].
            double mousePrice = double.Parse(Console.ReadLine());

            //• On the fourth line – keyboard price – floating - point number in the range[0…1000].
            double keyboardPrice = double.Parse(Console.ReadLine());

            //• On the fifth line – display price – floating - point number in the range[0… 1000].
            double displayPrice = double.Parse(Console.ReadLine());

            double sumAll = headsetPrice * (lostGames / 2);
            sumAll += mousePrice * (lostGames / 3);
            sumAll += keyboardPrice * (lostGames / 6);
            sumAll += displayPrice * (lostGames / 12);

            



            //Output
            //• As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
            Console.WriteLine($"Rage expenses: {sumAll:f2} lv.");
            //• Allowed working time / memory: 100ms / 16MB.
        }
    }
}
