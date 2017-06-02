using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { '.', ',', ';', ':', '(', ')', '[', ']', '/', '"', '\\', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(t => t.Length < 5)
                .Select(t => t.ToLower())
                .OrderBy(t => t)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ",text));

                

           

        }
    }
}
