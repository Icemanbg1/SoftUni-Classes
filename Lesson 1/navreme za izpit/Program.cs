using System;
using System.IO;

namespace navreme_za_izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8.Навреме за изпит

            // Вход

            // От конзолата се четат 4 цели числа(по едно на ред), въведени от потребителя:
            // •	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            int examHour = int.Parse(Console.ReadLine());
            // •	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            int examMinutes = int.Parse(Console.ReadLine());
            // •	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            int arrivalHour = int.Parse(Console.ReadLine());
            // •	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinutes;

            int differenceInMinutes = totalExamMinutes - totalArrivalMinutes;

            // Студент трябва да отиде на изпит в определен час(например в 9:30 часа).Той идва
            // в изпитната зала в даден час на пристигане(например 9:40).
            // - Счита се, че студентът е дошъл навреме, ако е пристигнал в часа
            //   на изпита или до половин час преди това.
            if (differenceInMinutes >= 0 && differenceInMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceInMinutes} minutes before the start");
            }
            // - Ако е пристигнал по-рано повече от 30 минути, той е подранил.
            if (differenceInMinutes > 30)
            {
                Console.WriteLine("Early");
                if (differenceInMinutes >= 60)
                {
                    int hours = differenceInMinutes / 60;
                    int minutes = differenceInMinutes - hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");

                    }

                }
                else
                {
                    Console.WriteLine($"{differenceInMinutes} minutes before the start");

                }
            }
            // - Ако е дошъл след часа на изпита, той е закъснял.
            if (differenceInMinutes < 0)
            {
                Console.WriteLine("Late");
                differenceInMinutes = -differenceInMinutes;
                if (differenceInMinutes >= 60)
                {
                    int hours = differenceInMinutes / 60;
                    int minutes = differenceInMinutes - hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");

                    }

                }
                else
                {
                    Console.WriteLine($"{differenceInMinutes} minutes after the start");

                }
            }
            // Напишете програма, която прочита време на изпит и време
            // на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е
            // закъснял и с колко часа или минути е подранил или закъснял.

            // Изход

            // На първият ред отпечатайте:
            // •	“Late”, ако студентът пристига по-късно от часа на изпита.
            // •	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            // •	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            // Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            // •	
            // “mm minutes after the start” за закъснение под час.
            // •	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите
            // винаги печатайте с 2 цифри, например “1:03”.

        }
    }
}
