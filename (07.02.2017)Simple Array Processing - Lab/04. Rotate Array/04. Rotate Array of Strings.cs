using System;
using System.Linq;

namespace Simple_Array_Processing
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] str = Console.ReadLine().Split(' ');
            string[] newStr = new string[str.Length];
            newStr[0] = str[str.Length - 1];
            for (int i = 0; i < str.Length - 1; i++)
            {
                newStr[i + 1] = str[i];
            }

            string stringResult = string.Join(" ", newStr);
            Console.WriteLine(stringResult);

        }

    }
}
