using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();


            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {

                    var currStr = arr[i];
                    var nextStr = arr[i + 1];

                    if (currStr.CompareTo(nextStr) == 1)
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swap = true;
                    }
                }

            }
            while (swap);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
