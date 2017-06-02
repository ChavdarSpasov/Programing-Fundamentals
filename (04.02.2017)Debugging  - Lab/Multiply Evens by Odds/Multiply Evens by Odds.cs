using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(result);

        }

        private static long GetMultipleOfEvensAndOdds(int n)
        {
            var oddSum = GetSumOfOddDigit(n);
            var evenSum = GetSumOfEvenDigit(n);

            return oddSum * evenSum;
        }

        private static int GetSumOfEvenDigit(int n)
        {
            n = Math.Abs(n);
            var even = 0;
            while (n > 0)
            {
                var dig = n % 10;
                n = n / 10;
                if (dig % 2 != 0)
                {
                    even += dig;
                }
            }
            return even;
        }

        private static int GetSumOfOddDigit(int n)
        {
            n = Math.Abs(n);
            var odd = 0;
            while (n > 0)
            {
                var dig = n % 10;
                n = n / 10;
                if (dig % 2 == 0)
                {
                    odd += dig;
                }
            }
            return odd;
        }
    }
}