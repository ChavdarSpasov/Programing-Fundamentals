using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var secList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input.Contains(input[i]) && !(secList.Contains(input[i])))
                {
                    secList.Add(input[i]);
                }

            }

            Console.WriteLine(string.Join(" ", secList));
        }
    }
}
