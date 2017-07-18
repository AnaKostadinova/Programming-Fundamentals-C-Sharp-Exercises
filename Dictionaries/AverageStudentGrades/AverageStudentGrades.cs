using System;
using System.Collections.Generic;
using System.Linq;

public class AverageStudentGrades
{
    public static void Main()
    {
        int numberOfStudens = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < numberOfStudens; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split();
            string name = elements[0];
            double grades = double.Parse(elements[1]);

            if (!studentGrades.ContainsKey(name))
            {
                studentGrades[name] = new List<double>();
            }
            studentGrades[name].Add(grades);
        }
        foreach (var kvp in studentGrades)
        {
            Console.Write($"{kvp.Key} -> ");

            foreach (double grade in kvp.Value)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
        }
    }
}