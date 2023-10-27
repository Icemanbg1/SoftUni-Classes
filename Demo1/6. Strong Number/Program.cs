using System;

using System.IO;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string number = Console.ReadLine();
            for (int i = 0; i < number.Length; i++)
            {
                int factoriel = 1;
                int currentNumber = int.Parse(number[i].ToString());
                for (int j = 1; j <= currentNumber; j++)
                {
                    factoriel *= j;
                }
                sum += factoriel;
            }
            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
