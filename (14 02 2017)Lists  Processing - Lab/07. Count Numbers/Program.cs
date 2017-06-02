using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            myList.Sort();


            var count = 1;

            for (int i = 0; i < myList.Count - 1; i++)
            {
                if (myList[i] == myList[i+1])
                {
                    count++;
                }
                else
                {
                    
                    Console.WriteLine($"{myList[i]} -> {count}");
                    count = 1;
                }

                
            }

            Console.WriteLine($"{myList[myList.Count-1]} -> {count}");

        }
    }
}
