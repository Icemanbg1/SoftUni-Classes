using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Your First Name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Write Your Lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Write Your Age");
            string age = Console.ReadLine();
            Console.WriteLine();    
            Console.WriteLine("Write Your Home Town");
            string town = Console.ReadLine();



            Console.WriteLine() ;   
            Console.WriteLine($"You are {name} {lastname},a {age}-years old person from {town}");

        }
    }
}