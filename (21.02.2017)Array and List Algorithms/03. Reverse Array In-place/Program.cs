using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var currIndex = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = currIndex;

            }

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
