using System;
using System.Collections.Generic;

class PhoneShop
{
    static void Main()
    {
        List<string> phones = new List<string>(Console.ReadLine().Split(", "));

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] command = input.Split(" - ");
            string action = command[0];
            string phone = command[1];

            if (action == "Add" && !phones.Contains(phone))
            {
                phones.Add(phone);
            }
            else if (action == "Remove" && phones.Contains(phone))
            {
                phones.Remove(phone);
            }
            else if (action == "Bonus phone")
            {
                string[] bonusCommand = phone.Split(':');
                string oldPhone = bonusCommand[0];
                string newPhone = bonusCommand[1];
                int index = phones.IndexOf(oldPhone);
                if (index != -1)
                {
                    phones.Insert(index + 1, newPhone);
                }
            }
            else if (action == "Last" && phones.Contains(phone))
            {
                phones.Remove(phone);
                phones.Add(phone);
            }
        }

        Console.WriteLine(string.Join(", ", phones));
    }
}