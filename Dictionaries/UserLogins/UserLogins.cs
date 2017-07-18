using System;
using System.Collections.Generic;
using System.Linq;

class UserLogins
{
    public static void Main()
    {
        string usernamerPasswordsPairs = Console.ReadLine();
        Dictionary<string, string> inputInventory = new Dictionary<string, string>();

        while (usernamerPasswordsPairs != "login")
        {
            string[] elements = usernamerPasswordsPairs.Split();
            string username = elements[0];
            string password = elements[2];

            if (!inputInventory.ContainsKey(username))
            {
                inputInventory[username] = password;
            }
            else
            {
                inputInventory[username] = password;
            }
            usernamerPasswordsPairs = Console.ReadLine();
        }

        usernamerPasswordsPairs = Console.ReadLine();
        int failedLogins = 0;
        while (usernamerPasswordsPairs != "end")
        {
            string[] elements = usernamerPasswordsPairs.Split();
            string usedUsername = elements[0];
            string usedPassword = elements[2];

            if (!(inputInventory.ContainsKey(usedUsername))
                || (inputInventory[usedUsername] != usedPassword))
            {
                failedLogins++;
                Console.WriteLine($"{usedUsername}: login failed");
            }
            else
            {
                Console.WriteLine($"{usedUsername}: logged in successfully");
            }
            usernamerPasswordsPairs = Console.ReadLine();
        }
        Console.WriteLine("unsuccessful login attempts: " + failedLogins);
    }
}