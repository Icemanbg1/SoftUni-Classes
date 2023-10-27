using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main()
        {
            // You are given an input of two values of the same type. The values can be of
            // type int, char or string.Create methods called GetMax(), which can compare
            // int, char or string and returns the biggest of the two values.

            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int intA = int.Parse(Console.ReadLine());
                    int intB = int.Parse(Console.ReadLine());
                    int all = GetMax(intA, intB);
                    Console.WriteLine(all);
                    break;

                case "char":
                    char charA = char.Parse(Console.ReadLine());
                    char charB = char.Parse(Console.ReadLine());
                    char all1 = GetMax(charA, charB);
                    Console.WriteLine(all1);
                    break;

                case "string":
                    string stringA = Console.ReadLine();
                    string stringB = Console.ReadLine();
                    string all2 = GetMax(stringA, stringB);
                    Console.WriteLine(all2);
                    break;


            }
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static string GetMax(string a, string b) 
        {
            return string.Compare(a, b) > 0 ? a : b;
        }

    }
}
