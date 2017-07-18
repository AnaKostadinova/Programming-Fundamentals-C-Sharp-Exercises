using System;
using System.Linq;


namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split().ToArray();
            var names = Console.ReadLine().Split().ToArray();
            string currentName = string.Empty;
            while (currentName != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == currentName)
                    {
                        Console.WriteLine(names[i] + " -> " + phoneNumbers[i]);
                    }
                 }
                currentName = Console.ReadLine();
            }
        }
    }
}
/*
 string[] numbers = Console.ReadLine().Split().ToArray();
        string[] names = Console.ReadLine().Split().ToArray();
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (names[j] == name)
                    {
                        Console.WriteLine(names[j] + " -> " + numbers[j]);
                    }
                    else if (name == "done")
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                    break;
                }

    */