using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");          
        }

        public static double Distance(Point2 first, Point2 second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result; 
        }

        public static Point2 ReadPoint()
        {
            var PointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point2
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }
    }
    public class Point2
    {
        public double X { get; set; }

        public double Y { get; set; }
    }

}
