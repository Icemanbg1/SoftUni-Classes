using System;

namespace plod_zelenchuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете име на продукт, въведено от потребителя,
            //и проверява дали е плод или зеленчук.
            string product = Console.ReadLine();

            //•	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
            switch (product) 
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                //•	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot

                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                    //•	Всички останали са "unknown"    

                default: Console.WriteLine("unknown");
                    break;
            }
            
            //Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.

        }
    }
}
