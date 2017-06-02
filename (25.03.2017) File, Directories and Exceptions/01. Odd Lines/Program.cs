using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLine = File.ReadAllLines("text.txt");

            Console.WriteLine(fileLine.Length);      
        }
    }
}
