using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            var ch = Console.ReadLine().ToCharArray();
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var output = new char[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    output [i] = (char)(ch[i] - num[i]);    
                }
                else
                {
                    output [i] = (char)(ch[i] + num[i]);
                }
            }

            Console.WriteLine(string.Join("",output));
        }
    }
}
