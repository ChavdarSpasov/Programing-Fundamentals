using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.JSON_Parse
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var inputLine = Console.ReadLine();

           
                var textToDelete = "[{}]";
                var texttoSplitByTheArray = new string[] { "},{" };
                var studentsInfo = inputLine
                    .Trim(textToDelete.ToCharArray())
                    .Replace("},{", "|").Split('|');


            var studentsData = new List<Student>();

            for (int i = 0; i < studentsInfo.Length; i++)
            {
                var currStudentInfo = studentsInfo[i].Replace("age", " ").Replace("name", " ").Replace("grades", " ").Split(new[] { '"', '\\', ',', '[', ']', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);


                if (currStudentInfo.Length <= 2)
                {
                    Console.WriteLine($"{currStudentInfo[0]} : {currStudentInfo[1]} -> {"None"}");
                }
                else
                {
                    Console.WriteLine($"{currStudentInfo[0]} : {currStudentInfo[1]} -> {string.Join(", ", currStudentInfo.Skip(2).ToArray())}");
                }

               

                Student currStudentData = new Student();
                currStudentData.Name = currStudentInfo[0];
                currStudentData.Age = int.Parse(currStudentInfo[1]);
                currStudentData.Grades = currStudentInfo.Skip(2).Select(int.Parse).ToArray();
                studentsData.Add(currStudentData);

            }



     

        }

    }
}
