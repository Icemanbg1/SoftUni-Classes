using System;
using System.Linq;

namespace Exer._10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldLenght = int.Parse(Console.ReadLine());

            int[] field = new int[fieldLenght];

            int[] bugPlaces = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int bugIndex = bugPlaces[i];
                if (bugIndex >= 0 && bugIndex < field.Length)
                {
                    field[bugIndex] = 1;
                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLenght = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > fieldLenght - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int landIndex = 0;
                switch (direction)
                {
                    case "right":
                        landIndex = bugIndex + flyLenght;
                        if (landIndex > field.Length - 1)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex += flyLenght;
                                if (landIndex > field.Length - 1)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                    case "left":
                        
                        landIndex = bugIndex - flyLenght;
                        
                        if (landIndex < 0)
                        {
                            continue;   
                        }

                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex -= flyLenght;
                                if (landIndex < 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex >= 0)
                        {
                            field[landIndex] = 1;
                        }
                        break;
                    
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
