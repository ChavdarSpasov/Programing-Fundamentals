using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Decode__Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleNumbers = Console.ReadLine().Split();

            var resultList = new List<char>();

            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                var currWord = doubleNumbers[i].Split('.');

                var leftSide = int.Parse(currWord[0]);
                var rightSide =  int.Parse(currWord[1]);

                resultList.Insert(i, (char)rightSide);
                resultList.Insert(i, (char)leftSide);
            }

            foreach (var result in resultList)
            {
                if (result != 0)
                {
                    Console.Write(result);
                }
            }
            

            

        }
                       
    }
}
