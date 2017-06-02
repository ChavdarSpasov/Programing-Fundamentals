using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string emptyString = "";
            string cyperString = "";

            string appendedString = "";

            bool spin = false;

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();

                if (currString.Equals(appendedString))
                {
                    
                    if (appendedString  == "spin")
                    {
                        n++;
                    }

                    cyperString = emptyString;

                }
                else
                {
                    appendedString = currString;

                    if (currString == "spin")
                    {
                        n++;
                        spin = !(spin);
                    }
                    else if (spin == false)
                    {

                        cyperString = cyperString + appendedString;
                    }
                    else
                    {

                        cyperString = currString + cyperString;
                    }
                }

            }
            Console.WriteLine(cyperString);

        }
    }
}
