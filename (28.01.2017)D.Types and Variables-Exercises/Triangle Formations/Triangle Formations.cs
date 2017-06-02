using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = int.Parse(Console.ReadLine());
            var sideB = int.Parse(Console.ReadLine());
            var sideC = int.Parse(Console.ReadLine());

            if (sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA> sideB)
            {
                Console.WriteLine("Triangle is valid.");


                if (sideC * sideC == sideA*sideA + sideB*sideB)
                {
                    
                    Console.WriteLine("Triangle has a right angle between sides a and b");

                }
                else if (sideB * sideB == sideA * sideA + sideC * sideC)
                {
                    
                    Console.WriteLine("Triangle has a right angle between sides a and c");

                }
                else if (sideA * sideA == sideB * sideB + sideC * sideC)
                {

                    Console.WriteLine("Triangle has a right angle between sides b and c");

                }
                else
                {
                    
                    Console.WriteLine("Triangle has no right angles");
                } 

                                
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
