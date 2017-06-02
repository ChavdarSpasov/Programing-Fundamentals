using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var splitInput = input.Split();
                var key = splitInput[0];
                var innerKey = splitInput[1];


                if (key != "flatten")
                {
                    var innerValue = splitInput[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    dictionary[key][innerKey] = innerValue;
                }

                else if (key == "flatten")
                {
                    key = splitInput[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }

                input = Console.ReadLine();
            }

            var orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in orderedDictionary)
            {
                Console.WriteLine("{0}", item.Key);

                var innerDictionary = item.Value
                    .Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var innerFlattenDictionary = item.Value
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                int count = 1;

                foreach (var kvp in innerDictionary)
                {
                    Console.WriteLine("{0}. {1} - {2}", count, kvp.Key, kvp.Value);

                    count++;
                }

                foreach (var kvp in innerFlattenDictionary)
                {
                    Console.WriteLine("{0}. {1}", count, kvp.Key);

                    count++;
                }

            }
        }
    }
}
