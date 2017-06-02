using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var patterns = Console.ReadLine().Split(new char[]{ ' ',','},StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var pattern in patterns)
            {
                text = text.Replace(pattern, new string('*', pattern.Length));

            }

            Console.WriteLine(text);
        }
    }
}
