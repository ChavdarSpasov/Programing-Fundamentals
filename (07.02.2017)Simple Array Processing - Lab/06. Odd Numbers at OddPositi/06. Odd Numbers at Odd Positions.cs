using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_OddPositi
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string text = Console.ReadLine();
            string[] arrStr = text.Split(' ');
            int[] arrInt = new int[arrStr.Length];
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = int.Parse(arrStr[i]);
                
            }

            for (int i = 0; i < arrInt.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (arrInt[i] % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {arrInt[i]}");
                    }   
                }
            }

            

        }
    }
}
