using System;
using System.Linq;
using System.Xml.Linq;

using Microsoft.VisualBasic;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that reads an array of strings, reverses it, and prints
            // its elements.The input consists of a sequence of space-separated strings.
            // Print the output on a single line(space separated).


            string[] text = Console.ReadLine().
                Split().
                ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                string firstElement = text[i];
                string lastElement = text[text.Length -1 -i];
                Console.Write($"{lastElement} ");
            }
        }
    }
}
