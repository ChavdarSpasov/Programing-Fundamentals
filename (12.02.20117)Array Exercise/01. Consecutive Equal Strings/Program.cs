using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');


            for (int i = input.Length - 1; i > 1; i--)
            {
                if (input[i] == input[i - 1] && input[i - 1] == input[i - 2])
                {
                    Console.Write(input[i] + " ");
                    Console.Write(input[i - 1] + " ");
                    Console.WriteLine(input[i - 2]);

                    break;

                }
            }
        }

    }

}