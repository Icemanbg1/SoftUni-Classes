using System;

namespace _8._Завършване
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която изчислява средната оценка на ученик от цялото
            // му обучение.На първия ред ще получите името на ученика, а на всеки следващ
            // ред неговите годишни оценки.0
            string name = Console.ReadLine();
            double score = 0;
            double sum = 0;
            int i = 0;
            for (i = 1; i <=12; i++)
            {
                score = double.Parse(Console.ReadLine());
                // Ученикът преминава в следващия клас, ако годишната
                // му оценка е по-голяма или равна на 4.00.Ако ученикът бъде скъсан повече от един
                // път, то той бива изключен и програмата приключва, като се отпечатва името на
                // ученика и в кой клас бива изключен.
                if (score >= 4)
                {
                    sum = score + sum;
                }
                else
                {
                    break;                   
                }
            }

            if (i >= 12)
            {
                // При успешно завършване на 12 - ти клас да се отпечата : 
                // "{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
            else
            {
                // "{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
                // Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
                Console.WriteLine($"{name} has been excluded at {i} grade");

            }
        }
    }
}
