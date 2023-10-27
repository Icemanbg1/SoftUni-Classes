using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmdArgs = command.Split();

            switch (cmdArgs[0])
            {
                case "exchange":
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = ExchangeList(numbers, index);
                    }
                    break;

                case "max":
                case "min":
                    string type = cmdArgs[1];
                    int indexToPrint = FindMaxOrMinIndex(numbers, type);
                    if (indexToPrint == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(indexToPrint);
                    }
                    break;

                case "first":
                case "last":
                    int count = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    List<int> result = FindFirstOrLast(numbers, count, type);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static List<int> ExchangeList(List<int> list, int index)
    {
        List<int> firstPart = list.Take(index + 1).ToList();
        List<int> secondPart = list.Skip(index + 1).ToList();
        return secondPart.Concat(firstPart).ToList();
    }

    static int FindMaxOrMinIndex(List<int> list, string type)
    {
        bool isEven = type == "even";
        int index = -1;
        int maxOrMinValue = isEven ? int.MinValue : int.MaxValue;

        for (int i = 0; i < list.Count; i++)
        {
            int currentNumber = list[i];
            if ((currentNumber % 2 == 0) == isEven)
            {
                if (isEven && currentNumber >= maxOrMinValue)
                {
                    maxOrMinValue = currentNumber;
                    index = i;
                }
                else if (!isEven && currentNumber <= maxOrMinValue)
                {
                    maxOrMinValue = currentNumber;
                    index = i;
                }
            }
        }

        return index;
    }

    static List<int> FindFirstOrLast(List<int> list, int count, string type)
    {
        bool isEven = type == "even";
        List<int> result = new List<int>();
        int found = 0;

        for (int i = 0; i < list.Count; i++)
        {
            int currentNumber = list[i];
            if ((currentNumber % 2 == 0) == isEven)
            {
                result.Add(currentNumber);
                found++;
            }

            if (found == count)
            {
                break;
            }
        }

        return result;
    }
}
