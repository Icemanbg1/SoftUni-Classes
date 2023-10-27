using System;

namespace Exer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());
            string word1 = word.ToLower();
            int sum = Sum(word1);

            Console.WriteLine(sum);


        }

        private static int Sum(string word)
        {
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    sum++;
                }

                else if (word[i] == 'e')
                {
                    sum++;
                }

                else if (word[i] == 'i')
                {
                    sum++;
                }

                else if (word[i] == 'o')
                {
                    sum++;
                }

                else if (word[i] == 'u')
                {
                    sum++;
                }

                else if (word[i] == 'y')
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
