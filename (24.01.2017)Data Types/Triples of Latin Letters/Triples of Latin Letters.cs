using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + n; i++)
            {
                for (int j = 'a' ; j < 'a' + n; j++)
                {
                    for (int k = 'a'; k < 'a' + n; k++)
                    {
                       
                        Console.Write((char)(i));
                        Console.Write((char)(j));
                        Console.WriteLine((char)(k));

                    }
                }
            }
            
        }
    }
}
