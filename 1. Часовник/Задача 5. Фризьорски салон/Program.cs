using System;
using System.Drawing;

namespace Задача_5._Фризьорски_салон
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Деси има фризьорски салон в София. Тя всеки ден си поставя за цел да постигне
            //определена печалба.Напишете програма, която изчислява дали е успяла да постигне
            //целта за деня, като знаете следното:

            //Деси ще приема клиенти докато не приключи работния ден.Ако постигне желания приход
            //обаче, тя ще затвори салона. Когато клиент влезе ще може да си избере една от
            //следните услуги:

            //Вход:

            //От конзолата първоначално се чете 1 ред:
            //•	цел за деня – цяло число в интервала[1 … 5000]
            int dailyTarget = int.Parse(Console.ReadLine());
            int sum = 0;
            string service = "";
            string type = "";
            int allSum = 0;
            //След това се четат поредица от редове до получаване на команда "closed"
            //или докато Деси не постигне целта за деня – услугата, която иска клиентът
            //– текст с възможности "haircut" и "color".
            while (true)
            {
                service = Console.ReadLine();
                if (service == "closed")
                {
                    break;
                }

                //•	Подстригване(haircut):
                if (service == "haircut")
                {
                    type = Console.ReadLine();
                    //o Мъжко(mens) -15лв.
                    if (type == "mens")
                    {
                        sum = 15;
                    }
                    //o Дамско(ladies) – 20лв.
                    else if (type == "ladies")
                    {
                        sum = 20;
                    }
                    //o Детско(kids) – 10лв.
                    else if (type == "kids")
                    {
                        sum = 10;
                    }
                }

                //•	Боядисване(color):
                else if (service == "color")
                {
                    type = Console.ReadLine();
                    //o Поддръжка(touch up) – 20лв.
                    if (type == "touch up")
                    {
                        sum = 20;
                    }
                    //o Пълно боядисване(full color) – 30лв.
                    else if (type == "full color")
                    {
                        sum = 30;
                    }
                }
                allSum = allSum + sum;
                if (allSum >= dailyTarget)
                {
                    break;
                }
            }
             

            

            //При команда "haircut" ще се очаква да се въведе видът на подстригването – "mens", "ladies" или "kids".
            //При команда "color" ще се очаква видът на боядисването – "touch up" или "full color".

            //Изход:
            //На конзолата се отпечатват 2 реда:
            //•	На първия ред:
            //            o Ако Деси е успяла да постигне целта за деня:
            //"You have reached your target for the day!"
            if (allSum >= dailyTarget)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {allSum}lv.");
            }
            //o Ако Деси не е успяла да постигне целта за деня:
            //            "Target not reached! You need {колко пари не и достигат, за да стигне целта}lv. more."
            //•	На втория ред:
            //            "Earned money: {парите, които е спечелила за деня}lv."
            else
            {
                Console.WriteLine($"Target not reached! You need {dailyTarget - allSum}lv. more.");
                Console.WriteLine($"Earned money: {allSum}lv.");
            }

        }
    }
}
