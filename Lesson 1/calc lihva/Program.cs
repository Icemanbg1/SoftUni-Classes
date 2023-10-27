using System;

namespace calc_lihva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int monts = int.Parse(Console.ReadLine());  
            double percent = double.Parse(Console.ReadLine());

            double interestY = sum * percent / 100;
            double interestM = interestY / 12;
            double all = sum + interestM * monts;

            Console.WriteLine(all);
            
        }
    }
}
