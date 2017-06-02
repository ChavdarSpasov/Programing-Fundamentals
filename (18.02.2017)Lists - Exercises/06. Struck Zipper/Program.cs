using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Struck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var minNumOfDigg = CalculateIdealNumberOfDiggits(list1, list2);

            for (int i = 0; i < list1.Count; i++)
            {
                var currNumberOfDiggit = NumberOfDiggits(list1[i]);
                if (currNumberOfDiggit > minNumOfDigg)
                {
                    list1.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < list2.Count; i++)
            {
                var currNumberOfDiggit = NumberOfDiggits(list2[i]);
                if (currNumberOfDiggit > minNumOfDigg)
                {
                    list2.RemoveAt(i);
                    i--;
                }
            }

            var insertionIndex = 1; 
            for (int i = 0; i < list1.Count; i++)
            {
                list2.Insert(Math.Min(insertionIndex,list2.Count),list1[i]);
                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ",list2));

        }

        private static int CalculateIdealNumberOfDiggits(List<int> list1, List<int> list2)
        {
            var minNumOfDig = int.MaxValue;

            for (int i = 0; i < list1.Count; i++)
            {
                if (NumberOfDiggits(list1[i]) < minNumOfDig)
                {
                    minNumOfDig = NumberOfDiggits(list1[i]);
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (NumberOfDiggits(list2[i]) < minNumOfDig)
                {
                    minNumOfDig = NumberOfDiggits(list2[i]);
                }
            }

            return minNumOfDig;
        }

        private static int NumberOfDiggits(int number)
        {

            number = Math.Abs(number);

            var diggits = 0;
            while (number>0)
            {
                number /= 10;
                diggits++;
            }

            return diggits;
        }
    }
}
