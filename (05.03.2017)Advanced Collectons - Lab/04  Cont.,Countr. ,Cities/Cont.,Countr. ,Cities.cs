using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__Cont._Countr._Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var continent = line[0];
                var country = line[1];
                var city = line[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();                    
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }

                data[continent][country].Add(city);
            }

            foreach (var item in data)
            {
                var continentName = item.Key;
                var townByCountry = item.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var element in townByCountry)
                {
                    var countryName = element.Key;
                    var townsName = element.Value;
                    Console.WriteLine($"{countryName} -> {string.Join(", ",townsName)}");
                }
            }


        }
    }
}
