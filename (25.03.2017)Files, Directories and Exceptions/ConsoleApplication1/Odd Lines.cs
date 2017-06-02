using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 1; i < file.Length; i += 2)
            {
                File.AppendAllText(output.txt,file);
         
            }
        }
    }
}
