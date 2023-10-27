using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cofeeType = Console.ReadLine().Split(" ").ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0;  i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                if (command == "Include")
                {
                    cofeeType.Add(Console.ReadLine());
                }
                else if (command == "Remove")
                {
                    string nextCommand = Console.ReadLine();
                    if (nextCommand == "first")
                    {
                        cofeeType.Remove(0);
                    }
                }
            }
        }
    }
}
