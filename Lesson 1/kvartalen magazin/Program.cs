using System;
using System.Net.Http.Headers;

namespace kvartalen_magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Предприемчив българин отваря квартални магазинчета в няколко града
            //и продава на различни цени според града:
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //град /  coffee  water   beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            if (town == "Sofia")
            {
                if(product == "coffee")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.6);
                }
            }

            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                if(product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if(product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.3);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.5);
                }
            }

            //Varna   0.45    0.70    1.10    1.35    1.55
            else if (town == "Varna")
            {
                if(product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.1);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }




            //Напишете програма, която чете продукт(низ), град(низ) и количество(десетично число),
            //въведени от потребителя, и пресмята и отпечатва колко струва съответното количество
            //от избрания продукт в посочения град. 

        }
    }
}
