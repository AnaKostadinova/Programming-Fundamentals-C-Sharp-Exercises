using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }

    public class Exercises
    {
        public static void Main()
        {
            string inputExercises = Console.ReadLine();
            
            List<Exercise> exerciseCollection = new List<Exercise>();

            while (inputExercises != "go go go")
            {
                string[] input = inputExercises.Split(new string[] {" -> ", ",", " "},
                    StringSplitOptions.RemoveEmptyEntries);
                List<string> problems = input.Skip(3).ToList();

                var r = ReadInput(input, problems);

                exerciseCollection.Add(r);


                inputExercises = Console.ReadLine();
            }

            foreach (var item in exerciseCollection)
            {
                Console.WriteLine($"Exercises: {item.Topic}\n" +
                                  $"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.\n" +
                                  $"Check your solutions here: {item.JudgeContestLink}");
                int bullet = 1;

                foreach (string problem in item.Problems)
                {
                    Console.WriteLine($"{bullet}. {problem}");
                    bullet++;
                }
            }
        }

        public static Exercise ReadInput(string[] input, List<string> problems)
            {
                Exercise elements = new Exercise()
                {
                    Topic = input[0],
                    CourseName = input[1],
                    JudgeContestLink = input[2],
                    Problems = problems
                };

                return elements;
            }
        }
    }