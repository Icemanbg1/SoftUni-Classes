using System;

namespace _3._Почивка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете
            // да разбере дали ще успее да събере необходимата сума. Тя спестява или
            // харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните
            // си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.

            // Вход
            // От конзолата се четат:

            // •	Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            double tripCost = double.Parse(Console.ReadLine());
            // •	Налични пари -реално число в интервала[0.00...25000.00]
            double currentMoney = double.Parse(Console.ReadLine());
            int spendingDays = 0;
            int savingDays = 0;
            string action = "";
            double sum = 0;

            // След това многократно се четат по два реда:
            while (currentMoney != tripCost)
            {
                // •	Вид действие – текст с възможности "spend" и "save"
                // •	Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]
                action = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    currentMoney -= sum;
                    spendingDays++;
                    if (currentMoney <= sum)
                    {
                        currentMoney = 0;
                    }
                    // •	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
                    // o   "You can't save the money."
                    // o   "{Общ брой изминали дни}"
                    if (spendingDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{spendingDays}");
                        break;
                    }
                }
                else if (action == "save")
                {
                    currentMoney += sum;
                    savingDays++;
                }
            }
            // •	Ако Джеси събере парите за почивката на конзолата се изписва:
            // o   "You saved the money for {общ брой изминали дни} days."
            if (currentMoney >= tripCost)
            {
                Console.WriteLine($"You saved the money for {savingDays + spendingDays} days.");
            }
            else if (currentMoney < tripCost && spendingDays < 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{spendingDays}");
            }
        }
    }
}
