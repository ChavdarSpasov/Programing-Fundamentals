using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var resulDict = new SortedDictionary<string, long>();

            var line = Console.ReadLine();

            while (line != "Over")
            {
                var currLine = line.Split(" :".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                var name = currLine[0];
                var number = currLine[1];

                var numberFromTryParse = 0l;
                var isNameANumberOrNot = long.TryParse(name, out numberFromTryParse);

                if (!isNameANumberOrNot)
                {
                    resulDict[name] = long.Parse(number);
                }
                else
                {
                    resulDict[number] = numberFromTryParse;
                }
                line = Console.ReadLine();
            }

            foreach (var kvp in resulDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
