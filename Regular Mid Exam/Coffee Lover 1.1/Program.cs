using System;
using System.Collections.Generic;
using System.Linq;

class CoffeeTracker
{
    static void Main()
    {
        List<string> coffeeList = Console.ReadLine()
            .Split(' ')
            .ToList();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            switch (command[0])
            {
                case "Include":
                    coffeeList.Add(command[1]);
                    break;
                case "Remove":
                    int numberOfCoffees = int.Parse(command[2]);
                    if (command[1] == "first")
                    {
                        if (numberOfCoffees <= coffeeList.Count)
                        {
                            coffeeList.RemoveRange(0, numberOfCoffees);
                        }
                    }
                    else if (command[1] == "last")
                    {
                        if (numberOfCoffees <= coffeeList.Count)
                        {
                            coffeeList.RemoveRange(coffeeList.Count - numberOfCoffees, numberOfCoffees);
                        }
                    }
                    break;
                case "Prefer":
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if (index1 >= 0 && index1 < coffeeList.Count && index2 >= 0 && index2 < coffeeList.Count)
                    {
                        string temp = coffeeList[index1];
                        coffeeList[index1] = coffeeList[index2];
                        coffeeList[index2] = temp;
                    }
                    break;
                case "Reverse":
                    coffeeList.Reverse();
                    break;
            }
        }

        Console.WriteLine("Coffees: ");
        Console.WriteLine(string.Join(" ", coffeeList));
    }
}
