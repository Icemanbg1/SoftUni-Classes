using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Exer._11._Array_Manipulator_Ver._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "exchange")
                {
                    int index = int.Parse(arguments[1]);
                    numbers = Exchange(numbers, index);
                }
                else if (arguments[0] == "max")
                {
                    string maxType = arguments[1];
                    PrintMaxNumber(numbers, maxType);
                }
                else if (arguments[0] == "min")
                {
                    string minType = arguments[1];
                    PrintMinNumber(numbers, minType);
                }
                else if (arguments[0] == "first")
                {
                    int firstLength = int.Parse(arguments[1]);
                    string firstType = arguments[2];
                    PrintFirstElements(numbers, firstLength, firstType);
                }
                else if (arguments[0] == "last")
                {
                    int lastLength = int.Parse(arguments[1]);
                    string lastType = arguments[2];
                    PrintLastElements(numbers, lastLength, lastType);
                }
            }
        }

        private static void PrintLastElements(int[] numbers, int lastLength, string lastType)
        {
                
        }

        private static void PrintFirstElements(int[] numbers, int length, string firstType)
        {
                
        }

        private static void PrintMinNumber(int[] numbers, string minType)
        {
                
        }

        private static void PrintMaxNumber(int[] numbers, string maxType)
        {
            int maxIndex = -1;
            int maxNumber = 0;

            for (int i = 0;  i < numbers.Length; i++)
            {

            }
        }

        private static int[] Exchange(int[] numbers, int index)
        {
            if (CheckForOutOfBound(numbers, index))
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }
            
            
            int[] changedArray = new int[numbers.Length];
            int changedArrayIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++) 
            {
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }
            return changedArray;
        }

        private static bool CheckForOutOfBound(int[] numbers, int index)
        {
            return index < 0 || index >= numbers.Length;
        }
    }
}
