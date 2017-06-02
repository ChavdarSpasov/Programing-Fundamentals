using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;

            decimal  earth = 4.22M * lightYear;
            var center = 26000 * lightYear;
            var milky = 100000 * lightYear;
            var observableUni = 46500000000 * lightYear;

            Console.WriteLine("{0:e2}", earth);
            Console.WriteLine("{0:e2}", center);
            Console.WriteLine("{0:e2}", milky);
            Console.WriteLine("{0:e2}", observableUni);
        }
    }
}
