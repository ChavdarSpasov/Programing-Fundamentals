using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.Rectangle_Position
{
    class Program
    {
        static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();
            var result = firstRectangle.IsInside(secondRectangle);

            Console.WriteLine(result?"Inside":"Not inside");

        }

        public static Recangle ReadRectangle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Recangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
        }
        
        
    }
}
