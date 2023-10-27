using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate how many courses will be needed to elevate n persons by using an
            // elevator of the capacity of p persons.The input holds two lines: the number
            // of people n and the capacity p of the elevator.

            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = numPeople / capacity;
            int courses1 = numPeople % capacity;
            courses = (int)Math.Ceiling((double)numPeople / capacity);
            Console.WriteLine(courses);
            //Console.WriteLine(courses1);
            //if (courses > 0)
            //{
            //    if (courses1 == 0)
            //    {
            //        Console.WriteLine($"{courses} courses * {capacity} people");

            //    }

            //    else if (courses1 > 0)
            //    {
            //        Console.WriteLine($"{courses} courses * {capacity} people \r\n+ {capacity / courses1} course * {courses1} persons");
            //    }
            //}
            //else if (courses == 0)
            //{
            //    Console.WriteLine("All the persons fit inside in the elevator.\r\nOnly one course is needed.");
            //}
        }
    }
}
