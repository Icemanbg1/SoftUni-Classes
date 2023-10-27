using System;


namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input / Constraints

            //The input data should be read from the console.It will consist of exactly 5 lines:
            //• The amount of money John has – floating - point number in the range[0.00…1000.00].
            double amountOfMoney = double.Parse(Console.ReadLine());

            //• The count of students – integer in the range[0…100].
            int studentsCount = int.Parse(Console.ReadLine());

            //• The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].
            double sabresPrice = double.Parse(Console.ReadLine());

            //• The price of robes for a single robe – floating - point number in the range[0.00…100.00].
            double robesPrice = double.Parse(Console.ReadLine());

            //• The price of belts for a single belt – floating - point number in the range[0.00…100.00].
            double beltsPrice = double.Parse(Console.ReadLine());

            //The input data will always be valid.There is no need to check it explicitly.

            double allSabres = Math.Ceiling(studentsCount * 1.1) * sabresPrice;
            double allRobes = studentsCount * robesPrice;
            double allBelts = (studentsCount - Math.Floor(studentsCount / 6.0)) * beltsPrice;
            double sumAll = allSabres + allRobes + allBelts;
            



            //Output

            //The output should be printed on the console.
            //• If the calculated price of the equipment is less or equal to the money John has:
            if (sumAll <= amountOfMoney)
            {
                //o "The money is enough - it would cost {the cost of the equipment}lv."
                Console.WriteLine($"The money is enough - it would cost {sumAll:f2}lv.");
            }

            //• If the calculated price of the equipment is more than the money John has:
            else
            {
                //o " John will need {neededMoney}lv more."
                double all = sumAll - amountOfMoney;
                Console.WriteLine($"John will need {all:f2}lv more.");
            }

            //• All prices must be rounded to two digits after the decimal point.

            //There are some additional requirements:
            //• Lightsabres sometimes break, so John should buy 10 % more(taken from the students' count), rounded up
            //to the next integer.
            //• Every sixth belt is free.
        }
    }
}
