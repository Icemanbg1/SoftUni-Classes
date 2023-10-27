using System;
using System.Threading.Channels;

namespace _5._Заплата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int payChek = int.Parse(Console.ReadLine());
            int ticket = 0;
            

            for (int i = 0; i < openTabs; i++)
            {
                string input = Console.ReadLine();
                if (input == "Facebook")
                {
                    ticket = 150;
                    payChek -= ticket;
                }
                else if (input == "Instagram")
                {
                    ticket = 100;
                    payChek -= ticket;
                }
                else if (input == "Reddit")
                {
                    ticket = 50;
                    payChek -= ticket;
                }

                if (payChek <= 0)
                {
                    break;
                }
            }

            if (payChek <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{payChek}");
            }

        }
    }
}
