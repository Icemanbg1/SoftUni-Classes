using System;

namespace Magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7.Пазаруване

            //петър иска да купи n видеокарти, m процесора и p на брой рам памет.ако броя на видеокартите е 
            //по-голям от този на процесорите получава 15 % отстъпка от крайната сметка.
            
            //вход
            //входът се състои от четири реда:

            //1.бюджетът на петър -реално число в интервала[0.0…100000.0]
            double budget = double.Parse(Console.ReadLine());

            //2.броят видеокарти - цяло число в интервала[0…100]
            int cardcount = int.Parse(Console.ReadLine());

            //3.броят процесори - цяло число в интервала[0…100]
            int processorcount = int.Parse(Console.ReadLine());

            //4.броят рам памет -цяло число в интервала[0…100]
            int ramcount = int.Parse(Console.ReadLine());

            //Bажат следните цени:

            //•	видеокарта – 250 лв./ бр.
            int card = 250;

            //•	процесор – 35 % от цената на закупените видеокарти/ бр.
            double processor = (card * cardcount) * 0.35;

            //•	рам памет – 10 % от цената на закупените видеокарти/ бр.
            double ram = (card * cardcount) * 0.1;


            // Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
            double allsum = card * cardcount + processor * processorcount + ram * ramcount;
            if (cardcount > processorcount) 
            {
                allsum *= 0.85;
            }

            //изход
            //на конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
            //•	ако бюджета е достатъчен:
            //"you have {остатъчен бюджет} leva left!"
            if (budget >= allsum)

            {
                Console.WriteLine($"You have {budget - allsum:f2} leva left!");
            }

            //•	ако сумата надхвърля бюджета:
            //"not enough money! you need {нужна сума} leva more!"
            else
            
            {
                Console.WriteLine($"Not enough money! You need {allsum - budget:f2} leva more!");
            }
            //резултатът да се форматира до втория знак след десетичната запетая. 

        }
    }
}
