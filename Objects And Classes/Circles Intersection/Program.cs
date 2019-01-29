using System;
using System.Linq;

namespace Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle(Console.ReadLine());
            Circle circle2 = ReadCircle(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(circle2.Center.X - circle1.Center.X, 2) + Math.Pow(circle2.Center.Y - circle1.Center.Y, 2));

            double sumRadius = circle1.Radius + circle2.Radius;

            bool intersect = distance <= sumRadius;

            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            Console.WriteLine("No");
        }

        private static Circle ReadCircle(string input)
        {
            double[] tokens = input.Split().Select(double.Parse).ToArray();

            double x = tokens[0];
            double y = tokens[1];
            double radius = tokens[2];

            Point center = new Point(x, y);
            Circle circle = new Circle(center, radius);

            return circle;
        }
    }

    class Point
    {
        public Point() { }

        public Point(double X, double Y)
        {
            this.X = X;

            this.Y = Y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }

    class Circle
    {
        public Circle(Point center, double radius)
        {
            this.Center = center;

            this.Radius = radius;
        }

        public Point Center { get; set; }

        public double Radius { get; set; }
    }

}
