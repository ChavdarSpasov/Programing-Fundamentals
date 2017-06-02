using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = TriangleArea(width,height);

            Console.WriteLine(area);
        }

        static double TriangleArea(double a, double b)
        {
            var result = a * b / 2;
            return result;
        }
     
    }
}
