using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double scm = double.Parse(Console.ReadLine());
            

            double price = scm * 7.61;
            double discaunt = price * 0.18;

            double fprice = price - discaunt;

            Console.WriteLine($"The final price is: {fprice} lv.");
            Console.WriteLine($"The discount is: {discaunt} lv.");
        }
    }
}