using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            
            var outputNumber = Convert.ToInt32(inputNumber,16);
            
            Console.WriteLine(outputNumber);
              
            


        }   
    }
}
