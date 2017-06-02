using System;
using System.Collections.Generic;
using System.Linq;


namespace Lambda_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var currNumber = int.Parse(Console.ReadLine());
                list.Add(currNumber);
            }

            var sum =list.Sum();
            var min = list.Min();
            var max = list.Max();
            var average = list.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
