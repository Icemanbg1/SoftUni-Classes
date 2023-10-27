using System;

namespace Exer._2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            //taka se pravi for cikul za masiv
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j] == secondArr[i])
                    {
                        Console.Write($"{firstArr[j]} ");
                    }
                }
            }

            //Console.WriteLine(string.Join(" ", firstArr));
            //Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
