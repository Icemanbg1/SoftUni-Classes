using System;

namespace Exer._9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that reads positive integers until you receive the
            // "END" command.For each number, print whether the number is a palindrome
            // or not.A palindrome is a number that reads the same backward as forward,
            // such as 323 or 1001.

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                bool isNumberPalindrome = IsPalindrome(input);
                Console.WriteLine(isNumberPalindrome);
            }
        }

        private static bool IsPalindrome(string symbols)
        {
            int left = 0;
            int right = symbols.Length - 1;

            while (left < right)
            {
                if (symbols[left] != symbols[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
