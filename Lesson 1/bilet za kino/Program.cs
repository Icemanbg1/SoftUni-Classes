using System;

namespace bilet_za_kino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8.Билет за кино
            // Да се напише програма която чете ден от седмицата(текст) –
            // въведен от потребителя и принтира на конзолата цената на билет за
            // кино според деня от седмицата:

            // Monday   Tuesday   Wednesday   Thursday    Friday   Saturday    Sunday
            //   12        12        14          14         12        16         16
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine("12");
            }

            else if (day == "Tuesday")
            {
                Console.WriteLine("12");
            }

            else if (day == "Wednesday")
            {
                Console.WriteLine("14");
            }

            else if (day == "Thursday")
            {
                Console.WriteLine("14");
            }

            else if (day == "Friday")
            {
                Console.WriteLine("12");
            }

            else if (day == "Saturday")
            {
                Console.WriteLine("16");
            }
            else
            {
                Console.WriteLine("16");
            }
            //Примерен вход и изход
            //вход изход       вход изход       вход изход
            //Monday  12      Friday  12      Sunday  16

        }
    }
}
