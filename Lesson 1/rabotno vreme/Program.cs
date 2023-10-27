using System;
using System.ComponentModel.Design;

namespace rabotno_vreme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Работно време

            //Да се напише програма, която чете час от денонощието(цяло число) и ден
            //от седмицата(текст) -въведени от потребителя и проверява дали офисът
            //на фирма е отворен, като работното време на офисът е от 10 - 18 часа,
            //от понеделник до събота включително

            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("open");
                        break;

                    case "Tuesday":
                        Console.WriteLine("open");
                        break;

                    case "Wednesday":
                        Console.WriteLine("open");
                        break;

                    case "Thursday":
                        Console.WriteLine("open");
                        break;

                    case "Friday":
                        Console.WriteLine("open");
                        break;

                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                }
            }

            else
            {              
                        Console.WriteLine("closed");
            }
            
            //Примерен вход и изход
            //вход    изход вход    изход вход    Изход
            //11
            //Monday open        19
            //Friday closed      11
            //Sunday Closed

        }
    }
}
