using System;
using System.Collections.Generic;
using System.Linq;

class FilterBase
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, int> databaseAge = new Dictionary<string, int>();
        Dictionary<string, double> databaseSalary = new Dictionary<string, double>();
        Dictionary<string, string> databasePosition = new Dictionary<string, string>();
        while (input != "filter base")
        {
            string[] elements = input.Split();
            string name = elements[0];
            string secondElement = elements[2];
            int age = 0;
            double salary = 0.0;

            if (int.TryParse(secondElement, out age))
            {
                databaseAge.Add(name, age);
            }
            else if (double.TryParse(secondElement, out salary))
            {
                databaseSalary.Add(name, salary);
            }
            else
            {
                databasePosition.Add(name, secondElement);
            }
            input = Console.ReadLine();
        }
        input = Console.ReadLine();
        if (input == "Age")
        {
            foreach (var kvp in databaseAge)
                Console.WriteLine($"Name: {kvp.Key}\nAge: {kvp.Value}" +
                                  $"\n====================");
        }
        else if (input == "Salary")
        {
            foreach (var kvp in databaseSalary)
                Console.WriteLine($"Name: {kvp.Key}\nSalary: {kvp.Value:f2}" +
                                  $"\n====================");
        }
        else
        {
            foreach (var kvp in databasePosition)
                Console.WriteLine($"Name: {kvp.Key}\nPosition: {kvp.Value}" +
                                  $"\n====================");
        }
    }
}