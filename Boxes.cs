using System;
using System.Collections.Generic;
using System.Linq;

namespace Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }


        public static int Perimeter(int width, int height)
        {
            var perimeter = 2 * (width + height);
            return perimeter;
        }

        public static int Area(int width, int height)
        {
            var area = (width * height);
            return area;
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public static double CalculateDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var allBoxes = new Dictionary<int, List<int>>();

            var input = Console.ReadLine();

            var count = 0;

            while (input != "end")
            {
                var parts = input
                    .Split(new[] { '|', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var UpperLeft_X = parts[0];
                var UpperLeft_Y = parts[1];
                var UpperRight_X = parts[2];
                var UpperRight_Y = parts[3];
                var BottomLeft_X = parts[4];
                var BottomLeft_Y = parts[5];
                var BottomRight_X = parts[6];
                var BottomRight_Y = parts[7];

                Point upperLeft = new Point();
                {
                    upperLeft.X = UpperLeft_X;
                    upperLeft.Y = UpperLeft_Y;
                }

                Point upperRight = new Point();
                {
                    upperRight.X = UpperRight_X;
                    upperRight.Y = UpperRight_Y;
                }

                Point bottomLeft = new Point();
                {
                    bottomLeft.X = BottomLeft_X;
                    bottomLeft.Y = BottomLeft_Y;
                }

                Point bottomRight = new Point();
                {
                    bottomRight.X = BottomRight_X;
                    bottomRight.Y = BottomRight_Y;
                }

                var width = (int)Point.CalculateDistance(bottomRight, bottomLeft);
                var height = (int)Point.CalculateDistance(bottomLeft, upperLeft);

                var perimeter = Box.Perimeter(width, height);
                var area = Box.Area(width, height);

                allBoxes[count] = new List<int>();
                allBoxes[count].Add(width);
                allBoxes[count].Add(height);
                allBoxes[count].Add(perimeter);
                allBoxes[count].Add(area);

                count++;

                input = Console.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Box: {allBoxes[i][0]}, {allBoxes[i][1]}");
                Console.WriteLine($"Perimeter: {allBoxes[i][2]}");
                Console.WriteLine($"Area: {allBoxes[i][3]}");
            }        
        }
    }
}
