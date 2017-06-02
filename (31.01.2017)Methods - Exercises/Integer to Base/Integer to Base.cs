using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number,toBase));
        }

        private static string IntegerToBase(int number, int toBase)
        {
            var result = "";
            
            while (number > 0)
            {
                var dig= number % toBase;
                number = number / toBase;

                result = dig.ToString() + result; 
            }
            
            return result;
        }
    }
}
