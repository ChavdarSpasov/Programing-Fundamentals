using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triscy_tR
{
    class Program
    {
        static void Main(string[] args)
        {


                var delimiter = Console.ReadLine();

                var numberOfStrings = int.Parse(Console.ReadLine());

                var result = string.Empty;

                for (int i = 0; i < numberOfStrings; i++)
                {
                    var currentString = string.Empty;
                    currentString += Console.ReadLine();

                    if (i == numberOfStrings - 1)
                    {
                        result += currentString;
                    }
                    else
                    {
                        result += currentString + delimiter;
                    }


                }

                Console.WriteLine(result);

            }
        }
    }


