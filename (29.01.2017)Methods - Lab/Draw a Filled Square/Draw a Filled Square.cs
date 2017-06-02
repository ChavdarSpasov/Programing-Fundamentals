using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFiledSquare(n);
        }
        
        static void PrintFiledSquare(int n)
        {
            PrintHeader(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }

            PrintHeader(n);
        }

        static void PrintBody(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-',n * 2));
        }
    }
}
