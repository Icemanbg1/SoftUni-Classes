using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           
            string lastname = Console.ReadLine();
           
            string age = Console.ReadLine();
           
            string town = Console.ReadLine();



           
            Console.WriteLine($"You are {name} {lastname}, a {age}-years old person from {town}.");

        }
    }
}