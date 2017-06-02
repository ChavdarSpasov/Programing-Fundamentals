using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<int>> result = new Dictionary<string, HashSet<int>>();


            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var inputSplit = input.Split();
                var region = inputSplit[0];
                var shell = int.Parse(inputSplit[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }

                result[region].Add(shell);

                
                input = Console.ReadLine();
            }

            foreach (var item in result)
            {

                Console.Write($"{item.Key} -> {string.Join(", ", item.Value)} ");

                var sum = 0;
                var count = 0;

                foreach (var element in item.Value)
                {
                    sum += element;
                    count++;
                }

                var bigshell = sum - (sum / count);

                if (count == 1)
                {
                    Console.WriteLine($"({sum})");
                }
                else
                {
                    Console.WriteLine($"({bigshell})");
                }

            }
        }
    }
}