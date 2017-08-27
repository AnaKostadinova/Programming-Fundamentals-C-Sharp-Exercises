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

                var tempCollection = ReadInput(input, problems);

                exerciseCollection.Add(tempCollection);

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
                Exercise elements = new Exercise
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

/*
 using System;
using System.Collections.Generic;
using System.Linq;

namespace test15
{
    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise(string topic, string courseName, string link, List<string> problems)
        {
            Topic = topic;
            CourseName = courseName;
            JudgeContestLink = link;
            Problems = new List<string>(problems);
        }

        public static Exercise ParseInput(string input)
        {
            string[] a = input.Split(new string[] {" -> ", ", "}, StringSplitOptions.RemoveEmptyEntries);
            List<string> allProblems = a.Skip(3).ToList();

            return new Exercise(a[0], a[1], a[2], allProblems);
        }
    }

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Exercise> exerciseData = new List<Exercise>();

            while (input != "go go go")
            {
                Exercise currentExercise = Exercise.ParseInput(input);
                exerciseData.Add(currentExercise);

                input = Console.ReadLine();
            }
            foreach (Exercise item in exerciseData)
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
    }
}

    */