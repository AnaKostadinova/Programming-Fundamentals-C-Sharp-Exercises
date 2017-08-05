using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            string studentsData = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            string[] dataPerStudent = studentsData.Split(new string[] {"},{"}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dataPerStudent.Length; i++)
            {
                string[] currentStudent = dataPerStudent[i]
                    .Split(new char[] {' ', '[', '{', ':', '\"', ',', ']', '}'},
                        StringSplitOptions.RemoveEmptyEntries);

                string name = currentStudent[1];
                int age = int.Parse(currentStudent[3]);
                List<int> grades = currentStudent.Skip(5).Select(int.Parse).ToList();
                
                if (grades.Count == 0)
                {
                    output.Append($"{name} : {age} -> None");
                }
                else
                {
                    output.Append($"{name} : {age} -> {string.Join(", ", grades)}");
                }

                Console.WriteLine(output.ToString());

                output.Clear();
            }
        }
    }
}