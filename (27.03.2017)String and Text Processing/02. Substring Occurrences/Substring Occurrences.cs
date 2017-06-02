using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var crchStr = Console.ReadLine().ToLower();

            var index = text.IndexOf(crchStr);
            var count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(crchStr, index + 1);
            }
            
            
            Console.WriteLine(count);
        }
    }
}
