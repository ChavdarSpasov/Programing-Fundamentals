using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0; int takova = 0; bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                { 
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{ takova} -> {toe}");
                obshto = 0;
               ch = takova;
            }
            */

            int n = int.Parse(Console.ReadLine());

            int checkedNumbe = 0;
         
            for (int currNumber = 1; currNumber <= n ; currNumber++)
            {
                checkedNumbe = currNumber;
                int sum = 0;
               
                while (checkedNumbe > 0)
                {
                    
                    sum += checkedNumbe % 10;
                    checkedNumbe = checkedNumbe / 10;
                }

                if ((sum == 5) || (sum == 7) || (sum == 11))
                    Console.WriteLine($"{currNumber} -> True");
                else
                    Console.WriteLine($"{currNumber} -> False");

            }
        }
    }
}
