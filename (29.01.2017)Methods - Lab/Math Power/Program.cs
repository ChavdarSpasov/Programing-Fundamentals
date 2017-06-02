using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var toPower = double.Parse(Console.ReadLine());

            var result = RaiseNumberToGivenPower(number, toPower);

            Console.WriteLine(result);
        }

        static double RaiseNumberToGivenPower(double number, double toPower)
        {
            var endResult = number;

            for (int i = 1; i < toPower; i++)
            {
                endResult *= number;
               
                
            }

            return endResult;
        }
    }
}
