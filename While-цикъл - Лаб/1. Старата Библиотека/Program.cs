using System;

namespace _1._Старата_Библиотека
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ани отива до родния си град след много дълъг период извън страната.
            // Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня
            // за любимата си книга.Помогнете на Ани, като напишете програма в която
            // тя въвежда търсената от нея книга(текст).Докато Ани не намери любимата
            // си книга или не провери всички в библиотеката, програмата трябва да чете
            // всеки път на нов ред името на всяка следваща книга(текст).Книгите в
            // библиотеката са свършили щом получите текст "No More Books".
            string book = Console.ReadLine();
            string book1 = Console.ReadLine();
            int count = 0;
            while (book1 != "No More Books" && book != book1)
            {
                book1 = Console.ReadLine();
                count++;               
            }

            // •	Ако открие книгата си се отпечатва един ред:
            // o   "You checked {брой} books and found it."
            if (book == book1)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }

            // •	Ако не открие търсената книгата да се отпечата на два реда:
            // o   "The book you search is not here!"
            // o   "You checked {брой} books."
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
