using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList( );

            var listTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();



            for (int i = 0; i < listOne.Count; i++)
            {
                if (listTwo.Contains(listOne[i]))
                {
                    listTwo.Remove(listOne[i]);
                }
            }


            var sumOfLists = SumOfListElements(listOne) + SumOfListElements(listTwo) ;
            var diffOfList = Math.Abs(SumOfListElements(listOne) - SumOfListElements(listTwo));


            if (SumOfListElements(listOne) == SumOfListElements(listTwo))
            {
                Console.WriteLine($"Yes. Sum: {SumOfListElements(listTwo)}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diffOfList}");
            }
            

        }

        private static int SumOfListElements(List<int> listOne)
        {
            var sum = 0;

            for (int i = 0; i < listOne.Count; i++)
            {
                sum += listOne[i];
            }

            return sum;

        }
    }
}
