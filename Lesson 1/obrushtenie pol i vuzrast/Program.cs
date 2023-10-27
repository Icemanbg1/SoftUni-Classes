﻿using System;

namespace obrushtenie_pol_i_vuzrast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише конзолна програма, която прочита възраст(реално число) и
            //пол('m' или 'f'), въведени от потребителя, и отпечатва обръщение измежду следните:
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else 
                {
                    Console.WriteLine("Miss");
                }
            }
            else 
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }

            }

            //•	"Mr." – мъж(пол 'm') на 16 или повече години
            //•	"Master" – момче(пол 'm') под 16 години
            //•	"Ms." – жена(пол 'f') на 16 или повече години
            //•	"Miss" – момиче(пол 'f') под 16 години

        }
    }
}
