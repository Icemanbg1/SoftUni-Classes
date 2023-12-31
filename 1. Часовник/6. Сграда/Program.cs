﻿using System;

namespace _6._Сграда
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която извежда на конзолата номерата на стаите в една
            // сграда(в низходящ ред), като са изпълнени следните условия:

            // •	На всеки четен етаж има само офиси
            // •	На всеки нечетен етаж има само апартаменти
            // •	Всеки апартамент се означава по следния начин: А{ номер на етажа}
            //            { номер на апартамента}, номерата на апартаментите започват от 0.
            // •	Всеки офис се означава по следния начин: О{ номер на етажа}
            //            { номер на офиса}, номерата на офисите също започват от 0.
            // •	На последният етаж винаги има апартаменти и те са по-големи от останалите,
            // за това пред номера им пише 'L', вместо 'А'.Ако има само един етаж, то има само
            // големи апартаменти!
            // От конзолата се прочитат две цели числа -броят на етажите и броят на стаите за един етаж.
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());

            for (int floor = floorCount; 0 < floor; floor--)
            {

                for (int room = 0; room < roomCount; room++)
                {
                    if (floorCount == floor)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else
                    {
                        if (floor % 2 == 0)
                        {
                            Console.Write($"O{floor}{room} ");
                        }
                        else
                        {
                            Console.Write($"A{floor}{room} ");

                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
