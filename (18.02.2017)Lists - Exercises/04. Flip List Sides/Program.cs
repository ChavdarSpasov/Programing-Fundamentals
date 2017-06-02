using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var lisdtWitLastTwoElements = new List<int>();

            lisdtWitLastTwoElements.Add(inputList[0]);
            inputList.RemoveAt(0);

            lisdtWitLastTwoElements.Add(inputList[inputList.Count - 1]);
            inputList.RemoveAt(inputList.Count - 1);

            inputList.Reverse();
            inputList.Add(lisdtWitLastTwoElements[1]);

            lisdtWitLastTwoElements.RemoveAt(1);
            for (int i = 0; i < inputList.Count; i++)
            {
                lisdtWitLastTwoElements.Add(inputList[i]);
            }


            foreach (var item in lisdtWitLastTwoElements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
