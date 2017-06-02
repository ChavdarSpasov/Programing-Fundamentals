using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); 
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var currInput = Console.ReadLine().Split();

                var name = currInput[0];
                var mark = currInput[1];

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(double.Parse(mark));
            }

            foreach (var kvp in grades)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:f2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");               
            }


        }

        
    }
}
