using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will receive three lines from the console:

            // • A count of people who are going on vacation.
            // • Type of the group(Students, Business or Regular).
            // • The day of the week which the group will stay on(Friday, Saturday or Sunday).
            // Based on the given information calculate how much the group will pay for the entire vacation.
            int pplCount = int.Parse(Console.ReadLine());
            double price = 0;
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double total = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
                if (pplCount >= 30)
                {
                    total = pplCount * price;
                    total *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
                if (pplCount >= 100)
                {
                    pplCount -= 10;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                if (pplCount >= 10 && pplCount <= 20)
                {
                    total = pplCount * price;
                    total *= 0.95;
                }
            }
            total = pplCount * price;
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
