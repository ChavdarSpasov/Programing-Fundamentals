using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string increasingSequence = " ";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    increasingSequence = "Yes";
                }
                else
                {
                    increasingSequence = "No";

                    break;
                }
            }


            Console.WriteLine(increasingSequence);
        }
    }
}
