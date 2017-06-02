using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }
}


public class Program
{
    public static void Main()
    {
        List<Student> myDataBase = new List<Student>();

        var input = Console.ReadLine();

        while (input != "stringify")
        {
            var inputLine = input
                .Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var currStudenInfo = new Student();

            currStudenInfo.Name = inputLine[0];
            currStudenInfo.Age = int.Parse(inputLine[1]);
            currStudenInfo.Grades = new List<int>();
            var newLine = inputLine.Skip(2);

            foreach (string element in newLine)
            {
                currStudenInfo.Grades.Add(int.Parse(element));
            }

            myDataBase.Add(currStudenInfo);

            input = Console.ReadLine();

        }

        Console.Write("[");

        for (int i = 0; i < myDataBase.Count; i++)
        {

            if (i == myDataBase.Count - 1)
            {
                Console.Write("{{name:\"{0}\",age:{1},grades:[{2}]}}", myDataBase[i].Name, myDataBase[i].Age, string.Join(", ", myDataBase[i].Grades));
            }
            else
            {
                Console.Write("{{name:\"{0}\",age:{1},grades:[{2}]}},", myDataBase[i].Name, myDataBase[i].Age, string.Join(", ", myDataBase[i].Grades));
            }

        }

        Console.Write("]");
    }
}