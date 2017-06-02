using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandNumber = Console.ReadLine().Split(' ');

            var num = double.Parse(commandNumber[0]);
                 
            for (int i = 1; i < commandNumber.Length ; i+=2)
            {
                if (commandNumber[i] == "up" )
                {
                    num += double.Parse(commandNumber[i + 1]);
                }
                else
                {
                    num -= double.Parse(commandNumber[i + 1]);
                }
               
            }

            bool result = num > 0;

            Console.WriteLine(result? $"got through safely. current altitude: {num}m": "crashed");
        }
    }
}
