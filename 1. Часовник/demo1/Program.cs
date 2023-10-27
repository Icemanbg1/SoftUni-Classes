using System;
using System.Reflection.Emit;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(1000);
            string label1 = DateTime.Now.ToString();
            Console.WriteLine(label1);
        }
    }
}
