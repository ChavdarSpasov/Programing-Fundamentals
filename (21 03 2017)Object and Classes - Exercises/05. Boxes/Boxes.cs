using System;
using System.Linq;
using System.Collections.Generic;

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public static double Distance(Point first, Point second)
    {
        var squreOfX = Math.Pow(first.X - second.X, 2);
        var squareOfY = Math.Pow(first.Y - second.Y, 2);

        return Math.Sqrt(squreOfX + squareOfY);
    }
}

public class Box
{
    public Point UpperLeft { get; set; }

    public Point UpperRight { get; set; }

    public Point BottomLeft { get; set; }

    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int width, int heidht)
    {
        var perimeter = (2 * width) + (2 * heidht);

        return perimeter;
    }

    public static int CalculateArea(int width, int heidht)
    {
        return width * heidht;
    }
}

public class Program
{
    public static void Main()
    {
        var listOfBoxes = new List<Box>();

        var inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            var currInput = inputLine
                .Split(new char[] { ':', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var currbox = new Box();
            currbox.UpperLeft = new Point { X = currInput[0], Y = currInput[1] };
            currbox.UpperRight = new Point { X = currInput[2], Y = currInput[3] };
            currbox.BottomLeft = new Point { X = currInput[4], Y = currInput[5] };
            currbox.BottomRight = new Point();
            currbox.BottomRight.X = currInput[6];
            currbox.BottomRight.Y = currInput[7];

            listOfBoxes.Add(currbox);



            inputLine = Console.ReadLine();
        }
        foreach (var box in listOfBoxes)
        {
            var width = Point.Distance(box.UpperLeft, box.UpperRight);
            var heidht = Point.Distance(box.UpperLeft, box.BottomLeft);

            var perimeter = Box.CalculatePerimeter((int)width, (int)heidht);
            var area = Box.CalculateArea((int)width, (int)heidht);

            Console.WriteLine("Box: {0}, {1}", width, heidht);
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);

        }



    }

}