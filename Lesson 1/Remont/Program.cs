using System;

namespace Remont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double plasticcm2 = (1.50);
            double paintl = (14.50);
            double thinerl = (5.00);
            double bag = (0.40);

            double plastic1 = double.Parse(Console.ReadLine());
            double paint1 = double.Parse(Console.ReadLine());
            double thiner1 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumplastic = (plastic1 + 2) * plasticcm2;
            double a = paint1 + (paint1 * 0.1);
            double sumpaint = a * paintl;
            double sumthiner = thinerl * thiner1;


            double summat = sumplastic + sumpaint + sumthiner + bag ;
            double sumwork = (summat * 0.3) * hours;

            double sumall = summat + sumwork;

            Console.WriteLine(sumall);





        }
    }
}
