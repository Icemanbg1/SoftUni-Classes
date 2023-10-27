using System;

namespace magazin_za_plodove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата плод
            // (banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            // ден от седмицата
            // (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday)
            // и количество(реално число) , въведени от потребителя,
            // и пресмята цената според цените от таблиците по-горе.Резултатът да се отпечата
            // закръглен с 2 цифри след десетичната точка. При невалиден ден от
            // седмицата или невалидно име на плод да се отпечата "error".
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
           
            // Магазин за плодове през работните дни работи на следните цени:

            // плод   banana   apple  orange  grapefruit kiwi    pineapple   grapes
            // цена    2.50    1.20    0.85      1.45    2.70      5.50       3.85

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday")

            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.50:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.20:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.70:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.50:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            // Събота и неделя магазинът работи на по - високи цени:
            // плод   banana   apple  orange  grapefruit kiwi    pineapple   grapes
            // цена    2.70    1.25    0.90      1.60    3.00      5.60       4.20

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.70:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.90:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.60:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3.00:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.60:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.20:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
