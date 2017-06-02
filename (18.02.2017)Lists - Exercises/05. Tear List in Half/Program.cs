using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myFirstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mySecondList = new List<int>();
            List<int> outputList = new List<int>();

            for (int i = 0; i < myFirstList.Count / 2; i++)
            {
                mySecondList.Add(myFirstList[i]);

            }

            myFirstList.RemoveRange(0, myFirstList.Count / 2);

            for (int i = 0; i < mySecondList.Count; i++)
            {
                outputList.Add(GetFistDigiFromTwoDigitsNumber(myFirstList[i]));
                outputList.Add(mySecondList[i]);
                outputList.Add(GetLastDigiFromTwoDigitsNumber(myFirstList[i]));
            }


            Console.WriteLine(string.Join(" ", outputList));
        }

        public static int GetFistDigiFromTwoDigitsNumber(int number)
        {


            var firstDigit = number / 10;

            return firstDigit;

        }

        public static int GetLastDigiFromTwoDigitsNumber(int number)
        {

            var LastDigit = number % 10;



            return LastDigit;
        }

    }
    }
}
