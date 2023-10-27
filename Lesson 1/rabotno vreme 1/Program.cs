using System;

namespace rabotno_vreme_1

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

            if (day == "Monday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

            else if (day == "Tuesday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

            else if (day == "Wednesday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

            else if (day == "Thursday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

            else if (day == "Friday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
        }

            else if (day == "Saturday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
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


    

