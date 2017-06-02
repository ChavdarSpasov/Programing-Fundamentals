using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();



            bool inOrder = false;

            do
            {
                inOrder = false;
                for (int i = 0; i < myList.Count - 1; i++)
                {
                    if (myList[i] > myList[i + 1])
                    {
                        ChangePosition(myList, i);

                        inOrder = true;
                    }

                }

            } while (inOrder);

            Console.WriteLine(string.Join(" ",myList));
        }

        private static void ChangePosition(List<int> myList, int i)
        {
            var temp = myList[i];
            myList[i] = myList[i + 1];
            myList[i + 1] = temp;
        }

    }
}
