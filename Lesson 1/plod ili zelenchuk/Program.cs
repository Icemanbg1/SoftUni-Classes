using System;

namespace plod_ili_zelenchuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9.Плод или зеленчук

            // Да се напише програма, която чете име на продукт, въведено от потребителя,
            // и проверява дали е плод или зеленчук.
            string product = Console.ReadLine();

            //•	Плодовете "fruit" имат следните възможни стойности:
            // banana, apple, kiwi, cherry, lemon и grapes

            //•	Зеленчуците "vegetable" имат следните възможни стойности:
            // tomato, cucumber, pepper и carrot

            //•	Всички останали са "unknown"
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

                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }

            //Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.
            //Примерен вход и изход

            //вход изход       вход изход       вход изход       вход изход
            //banana fruit       apple fruit       tomato vegetable       water unknown

        }
    }
}
