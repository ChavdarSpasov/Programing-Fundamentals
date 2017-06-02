using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currPoint = ReadPOint();
                points.Add(currPoint);
            }

            var minDistance = double.MaxValue;
            Point minFirstPoint = null;
            Point minSecondPoint = null;


            for (int firstPoint = 0; firstPoint < n; firstPoint++)
            {
                for (int secondPoint = firstPoint + 1; secondPoint < n; secondPoint++)
                {
                    if (Distance(points[firstPoint],points[secondPoint])<minDistance)
                    {
                        minDistance = Distance(points[firstPoint], points[secondPoint]);
                        minFirstPoint = points[firstPoint];
                        minSecondPoint = points[secondPoint];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(minFirstPoint.PrintXY());
            Console.WriteLine(minSecondPoint.PrintXY());

        }

        public static Point ReadPOint()
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var point = new Point { X = input[0], Y = input[1] };

            return point;
        }

        public static double Distance(Point pointOne, Point pointTwo)
        {
            var squareX = Math.Pow(pointTwo.X - pointOne.X, 2);
            var squareY = Math.Pow(pointTwo.Y - pointOne.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
