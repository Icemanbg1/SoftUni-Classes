using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

         
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int time = 3;


            int hours = time * project;






            Console.WriteLine($"The architect {name} will need {hours} hours to complete {project} project/s.");

        }
    }
}