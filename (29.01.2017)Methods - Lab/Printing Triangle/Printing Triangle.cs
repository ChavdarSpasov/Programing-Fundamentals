using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine()); 

            PrintTriangle(n);                 
            
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <=  n; i++)
            {
                PrintLine(i);               
            }
         
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);              
            }
        }

        static void PrintLine(int size)
        {
            for (int i = 1 ; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
       

    }
}
