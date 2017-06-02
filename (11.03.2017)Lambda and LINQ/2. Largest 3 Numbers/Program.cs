using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine()
                .Split()
                .Select(num => int.Parse(num))
                .ToList();

            var maxThreee = myList
                .OrderByDescending(x => x)
                .Take(3);
               

            Console.WriteLine(string.Join(" ",maxThreee));
        }
    }
}
