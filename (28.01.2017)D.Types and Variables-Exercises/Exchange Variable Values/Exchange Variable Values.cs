using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());

            

            var newA = 0;

            newA = b;
            b = a;

            Console.WriteLine($"{newA}\n{b}");
        }
    }
}
