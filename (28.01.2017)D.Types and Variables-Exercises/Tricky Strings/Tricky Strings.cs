using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

           string delimeter = Console.ReadLine();
           int number = int.Parse(Console.ReadLine());
          
           string emptyString = string.Empty;
          
           for (int i = 0; i < number - 1; i++)
           {
               string currString = Console.ReadLine();

                emptyString += currString + delimeter;


             // emptyString += currString;
             // if (i == number-1)
             // {
             //     break;
             // }
             // else
             // {
             //     emptyString += delimeter;  
             // }     
            }

            string lastString = Console.ReadLine();
            emptyString += lastString;

           Console.WriteLine(emptyString);
          


            



        }
    }
}
