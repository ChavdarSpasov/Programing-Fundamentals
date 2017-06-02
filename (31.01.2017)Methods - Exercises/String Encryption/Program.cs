using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char currIn = char.Parse(Console.ReadLine());

                result += (ConverCharToEncryptCode(currIn));
            }

            Console.WriteLine(result);
        }

        private static string ConverCharToEncryptCode(char str)
        {
            int num = str;
            var lastDig = num % 10;
            var firstDig = 0;

            while (num > 0)
            {
                firstDig = num % 10;
                num = num / 10;

            }

            string output = string.Empty;

            char firstchar = (char)(str + lastDig);
            char secondChar = (char)(str - firstDig);

            output = $"{firstchar}{firstDig}{lastDig}{secondChar}";

            return output;
        }
    }
}
