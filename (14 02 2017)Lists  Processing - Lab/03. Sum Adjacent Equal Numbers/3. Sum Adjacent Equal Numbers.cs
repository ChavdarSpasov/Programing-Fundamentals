using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int j = 0; j < input.Count - 1; j++)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                       
                        var newElement = input[i] + input[i + 1];
                        input.RemoveAt(i);
                        input.RemoveAt(i);
                        input.Insert(i, newElement);
                        break;

                    }
                   
                }
            }
  
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
