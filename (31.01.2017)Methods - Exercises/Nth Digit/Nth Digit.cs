using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(num,index));

        }

        static int FindNthDigit(int num, int index)
        {
            var currDigit = 0;

            while (index != 0)
            {
                currDigit = num % 10;
                num = num / 10;
                index--;
            }

            return currDigit;
        }
    }
}
