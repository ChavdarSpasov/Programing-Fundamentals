using System;
using System.Linq;

namespace _04.Distance__Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();


            var firstPoint = ReternPoint(inputOne);
            var secondPoint = ReternPoint(inputTwo);


            //var firstPoint = new Point();
            //firstPoint.X = inputOne[0];
            //firstPoint.Y = inputOne[1]; 

            //var secondPoint = new Point();
            //firstPoint.X = inputTwo[0];
            //firstPoint.Y = inputTwo[1];

            Console.WriteLine($"{Distance(firstPoint,secondPoint):f3}");

        }

        public static double Distance(Point pointOne, Point pointTwo)
        {
            var squareX = Math.Pow(pointTwo.X - pointOne.X, 2);
            var squareY = Math.Pow(pointTwo.Y - pointOne.Y,2);

            var result = Math.Sqrt(squareX + squareY);
                
                return result;
        }

        public static Point ReternPoint(string line)
        {
            var newLine = line.Split().Select(int.Parse).ToArray();

            return new Point { X = newLine[0], Y = newLine[1] };

        }
    }
}
