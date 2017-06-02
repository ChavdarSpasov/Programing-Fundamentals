using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] arr = text.Split(' ');

            int[] arrInt = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrInt[i] = int.Parse(arr[i]);
            }

            int odd = 0;

            foreach (var element in arrInt)
            {
                if (element % 2 != 0)
                {
                    odd += 1;
                }
            }

            Console.WriteLine(odd);
        }
    }
}
