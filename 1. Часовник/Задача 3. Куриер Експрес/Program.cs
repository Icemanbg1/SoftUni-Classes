using System;

namespace Задача_3._Куриер_Експрес
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Куриерска фирма доставя пратки в цялата страна.

            // Напишете програма, която да пресмята при зададено разстояние в км. , тегло на пратката и
            // вида услуга, каква ще бъде стойността за доставка на дадена пратка.

            // Вход
            // Входът се чете от конзолата и съдържа 3 реда:
            // 1.Тегло на пратката в килограми – реално число в интервала[0.01... 150.00]
            double pacageWeight = double.Parse(Console.ReadLine());
            // 2.Тип услуга –  текст със следните възможности: "standard" или "express"
            string typeServise = Console.ReadLine();
            // 3.Разстояние в километри – цяло число в интервала[1... 1000]
            int distanceKM = int.Parse(Console.ReadLine());
            double cost = 0;
            double allSum = 0;
            double overPrice = 0;

            // За услуга тип "standard", срокът за доставка е 3 работни дни и фирмата
            // калкулира цените при следните условия:
            if (typeServise == "standard")
            {
                // •	За пратки по - леки от 1 кг – 3 стотинки на километър.
                if (pacageWeight < 1)
                {
                    cost = 0.03;
                    allSum = cost * distanceKM;
                }
                // •	От 1 кг до 10 кг – 5 стотинки на километър.
                else if (pacageWeight >= 1 && pacageWeight < 10)
                {
                    cost = 0.05;
                    allSum = cost * distanceKM;
                }
                // •	От 10 кг вкл. до 40 кг – 10 стотинки на километър.
                else if (pacageWeight >= 10 && pacageWeight < 40)
                {
                    cost = 0.10;
                    allSum = cost * distanceKM;
                }
                // •	От 40 кг вкл. до 90  кг – 15 стотинки на километър.
                else if (pacageWeight >= 40 && pacageWeight < 90)
                {
                    cost = 0.15;
                    allSum = cost * distanceKM;
                }
                // •	От 90 кг вкл. до 150 кг – 20 стотинки на километър.
                else if (pacageWeight >= 90 && pacageWeight < 150)
                {
                    cost = 0.20;
                    allSum = cost * distanceKM;
                }
                else
                {
                    Console.WriteLine("Out of distance range");
                }
            }

            else if (typeServise == "express")
            {
                // За услуга тип "express", фирмата извършва услугата в рамките на 24 часа,
                // като начислява надценка за всеки километър както следва: 

                // •	За пратки по - леки от 1 кг – на килограм по 80 % от съответната цена на километър
                if (pacageWeight < 1)
                {
                    cost = 0.03;
                    overPrice = 0.8 * 0.03;
                    overPrice = overPrice * pacageWeight;
                    allSum = cost * distanceKM + overPrice * distanceKM;

                }
                // •	От 1 кг до 10  кг – на килограм по 40 % от съответната цена на километър
                else if (pacageWeight >= 1 && pacageWeight < 10)
                {
                    cost = 0.05;
                    overPrice = 0.4 * 0.05;
                    overPrice = overPrice * pacageWeight;
                    allSum = cost * distanceKM + overPrice * distanceKM;

                }
                // •	От 10 кг вкл. до 40 кг – на килограм по 5 % от съответната цена на километър
                else if (pacageWeight >= 10 && pacageWeight < 40)
                {
                    cost = 0.10;
                    overPrice = 0.05 * 0.10;
                    overPrice = overPrice * pacageWeight;
                    allSum = cost * distanceKM + overPrice * distanceKM;
                }
                // •	От 40 кг вкл. до 90  кг – на килограм по 2 % от съответната цена на километър
                else if (pacageWeight >= 40 && pacageWeight < 90)
                {
                    cost = 0.15;
                    overPrice = 0.02 * 0.15;
                    overPrice = overPrice * pacageWeight;
                    allSum = cost * distanceKM + overPrice * distanceKM;

                }
                // •	От 90 кг вкл. до 150 кг – на килограм по 1 % от съответната цена на километър
                else if (pacageWeight >= 90 && pacageWeight < 150)
                {
                    cost = 0.20;
                    overPrice = 0.01 * 0.20;
                    overPrice = overPrice * pacageWeight;
                    allSum = cost * distanceKM + overPrice * distanceKM;
                }
                else
                {
                    Console.WriteLine("Out of distance range");
                }
            }
            else
            {
                Console.WriteLine("Unsupported type of service");
            }


            // Изход
            // Да се отпечата на конзолата един ред:
            // "The delivery of your shipment with weight of {тегло} kg. would cost {цена} lv."
            
            Console.WriteLine($"The delivery of your shipment with weight of {pacageWeight:f3}" +
                $" kg. would cost {allSum:f2} lv.");

            // •	Теглото да бъде закръглено до третия знак след десетичната запетая
            // •	Цената да бъде закръглена до втория знак след десетичната запетая

        }
    }
}
