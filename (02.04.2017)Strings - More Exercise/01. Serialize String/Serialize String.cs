using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04_2017_Strings___More_Exercise
{

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var uniqueCharacters = new HashSet<char>();

            foreach (var item in input)
            {
                uniqueCharacters.Add(item);

            }

            var result = string.Empty;

            foreach (var item in uniqueCharacters)
            {
                result += item + ":";

                var index = input.IndexOf(item,0);

                while (index != -1)
                {
                    result += index + "/";
                    index = input.IndexOf(item, index + 1);
                }

                Console.WriteLine(result.Trim('/'));
                result = string.Empty;
            }

        }
    }
}
