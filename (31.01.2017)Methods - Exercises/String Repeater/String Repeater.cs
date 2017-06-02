using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var times = int.Parse(Console.ReadLine());

            var result = RepeatString(str,times);

            Console.WriteLine(result);
        }

        static string RepeatString(string yourString, int timesRepeat)
        {
            var myString = "";

            for (int i = 0; i < timesRepeat; i++)
            {
                
                myString += yourString;
            }

            return myString;
        }
    }
}
