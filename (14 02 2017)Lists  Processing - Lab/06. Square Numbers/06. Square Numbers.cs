using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
