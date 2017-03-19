using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currPoint = ReadPoint();

                points.Add(currPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first+1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var PointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}
