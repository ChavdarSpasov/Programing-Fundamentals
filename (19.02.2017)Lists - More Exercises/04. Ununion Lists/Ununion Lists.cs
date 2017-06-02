using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currList = Console.ReadLine().Split().Select(int.Parse).ToList();

                AddElementsToPrimeListWhichNotContainedInCurrList(primalList, currList);
                RemoveElementsFromPrimeListWhichContainedInCurrList(primalList, currList);

            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ",primalList));
        }

        private static void RemoveElementsFromPrimeListWhichContainedInCurrList(List<int> primalList, List<int> currList)
        {
            var currListChecked = false;
            while (!currListChecked == true)
            {
                for (int i = 0; i < primalList.Count; i++)
                {
                    if (currList.Contains(primalList[i]))
                    {
                        primalList.Remove(primalList[i]);
                        currListChecked = false;
                        break;
                    }
                    else
                    {
                        currListChecked = true;
                    }
                }

            }
        }

        private static void AddElementsToPrimeListWhichNotContainedInCurrList(List<int> primalList, List<int> currList)
        {
            var currListChecked = false;
            while (!currListChecked == true)
            {
                for (int i = 0; i < currList.Count; i++)
                {
                    if (!primalList.Contains(currList[i])&& currList.Count==1)
                    {
                        
                        primalList.Add(currList[i]);
                        currList.RemoveAt(i);
                        currListChecked = true;
                        break;
                    }
                    else if (!primalList.Contains(currList[i]))
                    {
                        primalList.Add(currList[i]);
                        currList.RemoveAt(i);
                        currListChecked = false;
                        break;
                    }
                    else
                    {
                        currListChecked = true;
                    }
                }

            }
        }
    }
}
