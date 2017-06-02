using System;
using System.Collections.Generic;
using System.Linq;



namespace _01.Remove_Neg.and_Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Reverse();
            
            List<int> output = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    output.Add(input[i]);
                }
            }

            Console.WriteLine(output.Count == 0 ? "empty" : string.Join(" ",output));
        }
    }
}
