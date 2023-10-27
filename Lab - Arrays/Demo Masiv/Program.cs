using System;
using System.Linq;


namespace Demo_Masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(items);

            Console.WriteLine(string.Join(" ", firstArr)); //prisuedinqva masiv
            isFirstArrSelected = !isFirstArrSelected; //promenq na true ili false do prikluchvane na cikula
        }                                             //zig zag efekt ili kluch na lampa /vkl izkl/

        string[] numbers = Console.ReadLine().Split(); //splitvane do string

        
        
        // pravi ot string masiv int
        int[] bugPlaces = Console.ReadLine().
            Split().
            Select(int.Parse).
            ToArray();

    }
}
