using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, int>();

            var line = Console.ReadLine();

            while (line != "end")
            {

                var currLine = line.Split();

                var firstElement = currLine[0];
                var lastElement = currLine[currLine.Length - 1];

                var resulFromTryParse = 0;
                var isLastElementNumber = int.TryParse(lastElement, out resulFromTryParse);

                if (isLastElementNumber)
                {
                    resultDict[firstElement] = resulFromTryParse;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var newVolueOfExistedKey = resultDict[lastElement];
                        resultDict[firstElement] = newVolueOfExistedKey;
                    }
                }

                line = Console.ReadLine();
            }


            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }

        }
    }
}
