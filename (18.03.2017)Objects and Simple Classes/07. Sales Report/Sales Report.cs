using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Sales_Report
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> result = new SortedDictionary<string,decimal>();

            for (int i = 0; i < n; i++)
            {
                var currSale = ReadSale();

                if (!result.ContainsKey(currSale.Town))
                {
                    result[currSale.Town] = 0m;
                }
                result[currSale.Town] += (currSale.Quantity * currSale.Price); 
            }


            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
          
        }

        public static Sale ReadSale()
        {
            var input = Console.ReadLine().Split().ToArray();

            return new Sale
            {
                Town = input[0],
                Products = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };        
        }
    }
}
