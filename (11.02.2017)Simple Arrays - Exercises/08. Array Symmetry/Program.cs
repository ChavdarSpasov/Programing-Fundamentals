using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().Split(' ');

            var isSymmetry = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
               if (word[i] != word[word.Length - i -1])
               {
                   isSymmetry = false;
                   break;
               }
            }

            Console.WriteLine(isSymmetry? "Yes" : "No");

              
           
        } 
    }
}
