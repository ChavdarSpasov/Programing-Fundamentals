using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataType = Console.ReadLine();


            switch (dataType)
            {
                case "int":
                    {
                        var numberOne = double.Parse(Console.ReadLine());
                        var numberTwo = double.Parse(Console.ReadLine());

                        var result = Max(numberOne, numberTwo);

                        Console.WriteLine(result);
                    }

                    break;
                case "char":
                    {
                        var numberOne = char.Parse(Console.ReadLine());
                        var numberTwo = char.Parse(Console.ReadLine());

                        var result = Max(numberOne,numberTwo);

                        Console.WriteLine(result);
                    }

                    break;
                case "string":
                    {
                        var numberOne = (Console.ReadLine());
                        var numberTwo = (Console.ReadLine());

                        var result = Max(numberOne, numberTwo);

                        Console.WriteLine(result);
                    }

                    break;


            }        
        }

        private static string Max(string numberOne, string numberTwo)
        {
            var max = " ";

            if (numberOne.CompareTo(numberTwo) >= 0)
            {
                return numberOne;
            }

            return numberTwo;
        }

        private static char Max(char numberOne, char numberTwo)
        {
            int char1Int = numberOne;
            int char2Int = numberTwo;

            return (char)Max(char1Int, char2Int);
        }

        private static double Max(double numberOne, double numberTwo)
        {            
            if (numberOne > numberTwo)
            {
                return numberOne;
            }
                         
            return numberTwo;
        }
    }
}
