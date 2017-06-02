using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length ; i++)
            {
                if (i == input[i])
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
