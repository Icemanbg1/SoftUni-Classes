using System;

namespace hotelska_staq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartment = 0, studio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    apartment = 65;
                    studio = 50;
                    break;
                case "June":
                case "September":
                    apartment = 68.70;
                    studio = 75.20;
                    break;
                case "July":
                case "August":
                    apartment = 77;
                    studio = 76;
                    break;
            }
            double allapartment = apartment * nights;
            double allstudio = studio * nights;

            if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    allstudio *= 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    allstudio *= 0.8;
                }

                allapartment *= 0.9;
            }
            else if (nights > 7)
            {
                if (month == "May" || month == "October")
                {
                    allstudio = 0.95;
                }
            }

            Console.WriteLine($"Apartment: {allapartment:f2} lv.");
            Console.WriteLine($"Studio: {allstudio:f2} lv.");

        }
    }
}
