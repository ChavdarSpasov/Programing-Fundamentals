using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
          var num = int.Parse(Console.ReadLine());
          
          
          string output = string.Empty;
          
          for (int i = 0; i < num; i++)
          {
              var currNumber = int.Parse(Console.ReadLine());
              output += (char)currNumber;
          }
          
          Console.WriteLine(output);
              
            
        }  
    }     
}
