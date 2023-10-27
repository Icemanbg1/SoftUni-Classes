using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // ▪ Provides operations to add / insert / remove / find
                //   elements
                // ▪ Add(element) – adds an element to the List<T>
                // ▪ Count – number of elements in the List< T >
                // ▪ Remove(element) – removes an element(returns true /
                //                                               false)
                // ▪ Insert(index, element) – inserts an element to a given
                //   index
                // ▪ Contains(element) – determines whether an element is
                //   in the list
                // ▪ Sort() – sorts the array / list in ascending order
            
                List<string> todos = new List<string>();
                todos.Add("Solve Judge lab problems");
                todos.Add("Break 10 minutes");
                todos.Add("Solve Judge ex problems");

                todos.Remove("Solve Judge lab problems");
                todos.Insert(1, "Go to store");

                List<int> number = new List<int>();
                List<int> number1 = new List<int>{1, 2, 3, 4};
                List<int> number2 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                List<int> number3 = new List<int>();
                for (int i = 0; i < 100; i++)
                {
                    number3.Add(int.Parse(Console.ReadLine()));;
                }

                number3.Reverse();
        }
    }
}
