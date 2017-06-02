using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CitiesContinentCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var townsDict = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var lineData = Console.ReadLine().Split();
                var continent = lineData[0];
                var country = lineData[1];
                var town = lineData[2];

                AddTown(townsDict, continent, country, town);


            }

            foreach (var continent in townsDict.Keys)
            {
                Console.WriteLine("{0}:",continent);

                foreach (var country in townsDict[continent].Keys)
                {
                    Console.WriteLine("{0} -> {1}",country,string.Join(", ", townsDict[continent][country]));
                }
            }
        }

        private static void AddTown(Dictionary<string, Dictionary<string, List<string>>> town, string continent, string country, string townInCountry)
        {
            if (!town.ContainsKey(continent))
            {
                town[continent] = new Dictionary<string, List<string>>();
            }
            if (!town[continent].ContainsKey(country))
            {
                town[continent][country] = new List<string>();
            }
            town[continent][country].Add(townInCountry);
        }
    }
}
