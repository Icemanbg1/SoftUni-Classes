using System;

namespace _3._Почивка_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int spendingDays = 0;
            int allDays = 0;
            string action = "";
            double sum = 0;

            while (true)
            {
                action = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                allDays++;
                if (action == "save")
                {
                    currentMoney += sum;
                    spendingDays = 0;
                }
                else if (action == "spend")
                {
                    currentMoney -= sum;
                    if (currentMoney < sum)
                    {
                        currentMoney = 0;
                    }
                    spendingDays++;
                }
                if (spendingDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{allDays}");
                    break;  
                }
                if (currentMoney >= tripCost)
                {
                    Console.WriteLine($"You saved the money for {allDays} days.");
                    break;
                }

            }
        }
    }
}
