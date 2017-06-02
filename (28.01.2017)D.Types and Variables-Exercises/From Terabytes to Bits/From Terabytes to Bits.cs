using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());

            long bits = 1024L*1024L*1024L*1024L*8;
            double result = terabytes * bits;
            Console.WriteLine(result);
            

        }
    }
}
