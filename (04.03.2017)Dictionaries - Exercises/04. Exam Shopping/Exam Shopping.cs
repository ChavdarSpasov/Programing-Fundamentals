using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, int>();

            var line = Console.ReadLine();

            
            while (line != "shopping time")
            {
                var currLine = line.Split();
                var product = currLine[1];
                var quantity = int.Parse(currLine[2]);

                if (!resultDict.ContainsKey(product))
                {
                    resultDict[product] = 0;
                }

                resultDict[product] += quantity;

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "exam time")
            {
                var currLine = line.Split();
                var product = currLine[1];
                var quantity = int.Parse(currLine[2]);

                if (!resultDict.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (resultDict[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        resultDict[product] -= quantity;

                        if (resultDict[product] < 0)
                        {
                            resultDict[product] = 0;
                        }    
                    }
                }

                line = Console.ReadLine();

            }


            foreach (var item in resultDict)
            {
                if (item.Value >0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                
            }
        }
    }
}
