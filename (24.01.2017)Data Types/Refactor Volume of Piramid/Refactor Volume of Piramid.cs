using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double dul, sh, V = 0;

            Console.Write("Length:");

            dul = double.Parse(Console.ReadLine());

            Console.Write("Width:");

            sh = double.Parse(Console.ReadLine());

            Console.Write("Heigth:");

            V = double.Parse(Console.ReadLine());

            V = (dul + sh + V) / 3;

            Console.WriteLine("Pyramid Volume: { 0:F2}", V);
            */

            double length = 0;
            double width = 0;
            double heigth = 0;
            double volume = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            volume = (length + width + heigth);
            Console.WriteLine("Pyramid Volume: {0:f2}",volume);


        }
    }
}
