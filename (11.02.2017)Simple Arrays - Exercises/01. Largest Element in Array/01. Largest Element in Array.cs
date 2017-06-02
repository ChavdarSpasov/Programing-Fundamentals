using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int negative = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
