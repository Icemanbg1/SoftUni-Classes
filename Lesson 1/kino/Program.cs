using System;

namespace kino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Кино

            // Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони
            // в залата(цели числа), въведени от потребителя, и изчислява общите приходи от
            // билети при пълна зала.Резултатът да се отпечата във формат като в примерите
            // по-долу, с 2 знака след десетичната точка.
            string type = Console.ReadLine();
            int collums = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());


            // В една кинозала столовете са наредени в правоъгълна форма в r реда
            // и c колони.Има три вида прожекции с билети на различни цени:

            // •	Premiere – премиерна прожекция, на цена 12.00 лева.
            // •	Normal – стандартна прожекция, на цена 7.50 лева.
            // •	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            if (type == "Premiere")
            {
                Console.WriteLine($"{collums * rows * 12.00:f2}");
            }
            else if (type == "Normal")
            {
                Console.WriteLine($"{collums * rows * 7.50:f2}");
            }
            else
            {
                Console.WriteLine($"{collums * rows * 5.00:f2}");
            }

        }
    }
}
