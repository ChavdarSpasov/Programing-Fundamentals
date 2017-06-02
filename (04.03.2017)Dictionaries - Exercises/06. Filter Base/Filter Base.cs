using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAgeDict = new Dictionary<string, int>();
            var nameSalaryDict = new Dictionary<string, decimal>();
            var namePositionDict = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "filter base")
            {
                var currLine = line.Split();
                var name = currLine[0];
                var data = currLine[2];

                var intNumber = 0;
                var decimalNumber = 0m;

                if (int.TryParse(data, out intNumber))
                {
                    nameAgeDict[name] = intNumber;
                }
                else if (decimal.TryParse(data, out decimalNumber))
                {
                    nameSalaryDict[name] = decimalNumber;
                }
                else
                {
                    namePositionDict[name] = data;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            switch (line)
            {
                case "Age":
                    foreach (var kvp in nameAgeDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Age: {kvp.Value}");
                        Console.WriteLine(new string('=',20));
                    }
                    break;
                case "Position":
                    foreach (var kvp in namePositionDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var kvp in nameSalaryDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine("Salary: {0:f2}",kvp.Value);
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }

        }
    }
}
