using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = double.Parse(Console.ReadLine());
            var numTwo = double.Parse(Console.ReadLine());
            var numThree = double.Parse(Console.ReadLine());

            var result = 0d;

            if ((numThree) > GetMin(numOne, numTwo))
            {
                result = GetMin(numOne, numTwo);
            }
            else
            {
                result = numThree;
            }

            Console.WriteLine(result);

        }

        static double GetMin(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return secondNumber;
            }

            return firstNumber;
        }
    }
}
