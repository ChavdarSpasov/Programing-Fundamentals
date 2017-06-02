using System;
using System.Linq;

namespace Simple_Array_Processing
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] str = Console.ReadLine().Split(' ');
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }

            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);
        }

    }
}
