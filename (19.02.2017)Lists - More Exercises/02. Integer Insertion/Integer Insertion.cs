using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var currList = Console.ReadLine();

            while (currList != "end")
            {

                var indexToAdd = GetFirstDigOfNum(currList);

                input.Insert(indexToAdd, currList);

                currList = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static int GetFirstDigOfNum(string num)
        {
            var number = int.Parse(num);
            var firstDig = 0;
            while (number > 0)
            {
                firstDig = number % 10;
                number = number / 10;
            }

            return firstDig;

        }


    }
}
