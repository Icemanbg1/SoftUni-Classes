using System;

namespace Spisuk_knigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesb = int.Parse(Console.ReadLine());
            int pagesh = int.Parse(Console.ReadLine());   
            int days = int.Parse(Console.ReadLine()); 

            int a = pagesb / pagesh;
            int b = a / days;

            Console.WriteLine(b);


        }
    }
}
