using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            var input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries); ;

            var nameOfTree = input[0];
            var heightOfTree = int.Parse(input[1]);
            var numberOfTrees = 0;
            while (nameOfTree != "chop")
            {               
                
                if (!dictionary.ContainsKey(nameOfTree))
                {
                    dictionary[nameOfTree] = new List<int>();
                }

                dictionary[nameOfTree].Add(int.Parse(input[1]));

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries); ;

                nameOfTree = input[0];
                numberOfTrees++;
            }

            var typeOfTheTree = Console.ReadLine();
            var minLengthPerTree = int.Parse(Console.ReadLine());

            var dicOfUseTree = dictionary
                .Where(x => x.Key == typeOfTheTree)
                .ToDictionary(x => x.Key, x => x.Value);

            dicOfUseTree[typeOfTheTree] = dicOfUseTree[typeOfTheTree]
                .Where(x => x >= minLengthPerTree)
                .ToList();

            var dicOfUnuseTree = dictionary
                .Where(x => x.Key != typeOfTheTree)
                .ToDictionary(x => x.Key, x => x.Value);

            var sumOfAllLogs = 0.0;
            foreach (var list in dictionary.Values)
            {
                foreach (var element in list)
                {
                    sumOfAllLogs += element;
                }
            }

            double pricePerMeter = Math.Round(sumOfAllLogs / numberOfTrees,2);


            var sumOfLogTree = 0.0;
            foreach (var item in dicOfUseTree)
            {
                foreach (var list in item.Value)
                {
                    sumOfLogTree += list;
                }
            }

            double sumOfUseLogPrice = sumOfLogTree * pricePerMeter;


            var sumOfUnlogTrees = 0.0;
            foreach (var list in dicOfUnuseTree)
            {
                foreach (var element in list.Value)
                {
                    sumOfUnlogTrees += element;
                }
            }

            var leftOfUsedTree = dictionary[typeOfTheTree]
                .Where(x => x < minLengthPerTree).ToList();

            var sumOfUnuselogPrice = (sumOfUnlogTrees + leftOfUsedTree.Sum()) * pricePerMeter * 0.25;

            var sumOfCottageScraper = sumOfUnuselogPrice + sumOfUseLogPrice;



            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${sumOfUseLogPrice:f2}");
            Console.WriteLine($"Unused logs price: ${sumOfUnuselogPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${sumOfCottageScraper:f2}");
        }
    }
}
