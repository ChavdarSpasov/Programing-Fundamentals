using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2017_Lists___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();


            List<string> output = new List<string>();


            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    output.Add(input[i]);
                }
            }
            foreach (var element in output)
            {
                Console.Write(element);
            }
            Console.WriteLine();

        }
    }
}
