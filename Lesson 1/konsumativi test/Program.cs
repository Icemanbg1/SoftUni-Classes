using System;

namespace konsumativi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pen = (5.80);
            Console.WriteLine(pen);
            double mark = (7.20);
            Console.WriteLine(mark);
            double clean = (1.20);
            Console.WriteLine(clean);

            int numpen = int.Parse(Console.ReadLine());
            Console.WriteLine(numpen);
            int nummark = int.Parse(Console.ReadLine());
            Console.WriteLine(nummark);
            int numclean = int.Parse(Console.ReadLine());
            Console.WriteLine(numclean);
            double percent = int.Parse(Console.ReadLine());
            Console.WriteLine(percent);

            double penprice = pen * numpen;
            Console.WriteLine(penprice);
            double markprice = mark * nummark;
            Console.WriteLine(markprice);
            double cleanprice = clean * numclean;
            Console.WriteLine(cleanprice);
            double priceall = penprice + markprice + cleanprice;
            Console.WriteLine(priceall);
            double v = percent / 100;
            Console.WriteLine(v);
            double pricediscount = priceall - (priceall * v);

            Console.WriteLine(pricediscount);



        }
    }
}
