using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);

            var result = new SortedDictionary<double, int>();

            foreach (var number in Numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }
                result[number]++;
            }


            foreach (var kvp in result)
            {           
                Console.WriteLine( $"{kvp.Key} -> {kvp.Value} ");
            }
        }
    }
}
