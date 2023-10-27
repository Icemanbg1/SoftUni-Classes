using System;

namespace turgovski_komisionni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12.Търговски комисионни 

            //    Напишете конзолна програма, която чете име на град(стринг) и
            // обем на продажби(реално число) , въведени от потребителя, и изчислява и
            // извежда размера на търговската комисионна според горната таблица.Резултатът да се
            // изведе форматиран до 2 цифри след десетичната точка. При невалиден град или
            // обем на продажбите(отрицателно число) да се отпечата "error".
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            //    Фирма дава следните комисионни на търговците си според града, в който
            //    работят и обема на продажбите:

            //    Град    0 ≤ s ≤ 500      500 < s ≤ 1 000     1 000 < s ≤ 10 000      s > 10 000
            //    Sofia       5 %                7 %                   8 %                 12 %
            //    Varna       4.5 %              7.5 %                 10 %                13 %
            //    Plovdiv     5.5 %              8 %                   12 %                14.5 %

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales = sales * 0.05:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales = sales * 0.07:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales = sales * 0.08:f2}");
                }

                else if (sales >10000)
                {
                    Console.WriteLine($"{sales = sales * 0.12:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales = sales * 0.045:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales = sales * 0.075:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales = sales * 0.10:f2}");
                }

                else if (sales >10000)
                {
                    Console.WriteLine($"{sales = sales * 0.13:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales = sales * 0.055:f2}");
                }

                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales = sales * 0.08:f2}");
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales = sales * 0.12:f2}");
                }

                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales = sales * 0.145:f2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
     
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
