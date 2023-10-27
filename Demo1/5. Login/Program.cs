using System;
using System.Collections.Generic;

using static System.Net.Mime.MediaTypeNames;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // On the first line, you will be given a username and your task is to try to log in the user.
            // The user's password is the username reversed. On the next lines, you will receive passwords:

            // • If the password is incorrect, print "Incorrect password. Try again.".
            // • If the password is correct, print "User {username} logged in." and stop the program.

            // Keep in mind that if the password is still incorrect on the fourth attempt,
            // you should print: "User {username} blocked!".
            // Then the program stops.
            string username = Console.ReadLine();
            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);
            int count = 0;
            while (true)
            {
                if (count >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                string pass = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                }
            }
        }
    }
}
