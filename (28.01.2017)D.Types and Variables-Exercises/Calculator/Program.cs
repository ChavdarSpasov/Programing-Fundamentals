using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOne = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());

            int adding = numberOne + numberTwo;
            int subtracting = numberOne - numberTwo;
            int multiplication = numberOne * numberTwo;
            int devision = numberOne / numberTwo;

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{numberOne} + {numberTwo} = {adding}");
                    break;
                case "-":
                    Console.WriteLine($"{numberOne} - {numberTwo} = {subtracting}");
                    break;
                case "*":
                    Console.WriteLine($"{numberOne} * {numberTwo} = {multiplication}");
                    break;
                default:
                    Console.WriteLine($"{numberOne} / {numberTwo} = {devision}");
                    break;
            }
               
          
        }
    }
}
