using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        CalculateTriangle(side, height);
                        break;
                    }
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        CalculateSquare(side);
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        CalculateRectangle(width, height);
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        CalculateCircle(radius);
                        break;
                    }
            }
        }

        private static void CalculateCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void CalculateRectangle(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"{area:f2}");
        }

        private static void CalculateSquare(double side)
        {
            double area = Math.Pow(side, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void CalculateTriangle(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
