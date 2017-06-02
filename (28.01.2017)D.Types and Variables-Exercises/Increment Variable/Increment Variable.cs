using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = int.Parse(Console.ReadLine());
            //
            //
            // Console.WriteLine(num%256);
            //
            // Console.WriteLine("Overflowed {0} times",num/256);

            int n = int.Parse(Console.ReadLine());

            byte dataType = 0;
            int overflow = 0;

            for (int i = 0; i < n; i++)
            {

                dataType++;

                if (dataType == 0)
                {
                    overflow++;
                }
            }

            Console.WriteLine(dataType);
            Console.WriteLine("Overflowed {0} times", overflow);

        }
    }
}
