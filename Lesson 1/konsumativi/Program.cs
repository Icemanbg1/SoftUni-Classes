using System;

namespace konsumativi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pen = (5.80);
            double mark = (7.20);
            double clean = (1.20);

            int numpen = int.Parse(Console.ReadLine());
            int nummark = int.Parse(Console.ReadLine());
            int numclean = int.Parse(Console.ReadLine());
            double percent = int.Parse(Console.ReadLine());

            double penprice = pen * numpen;
            double markprice = mark * nummark;
            double cleanprice = clean * numclean;
            double priceall = penprice + markprice + cleanprice;
            double v = percent / 100;
            double pricediscount = priceall - (priceall * v);

            Console.WriteLine(pricediscount);



        }
    }
}
