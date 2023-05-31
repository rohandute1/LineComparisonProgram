using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            Console.WriteLine("Enter the first line coordinates (x1, y1, x2, y2):");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Line line1 = new Line(new Point(x1, y1), new Point(x2, y2));

            Console.WriteLine("Enter the second line coordinates (a1, b1, a2, b2):");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            Line line2 = new Line(new Point(a1, b1), new Point(a2, b2));

            int comparisonResult = line1.CompareTo(line2);

            if (comparisonResult == 0)
            {
                Console.WriteLine("The two lines are equal in length.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first line is greater than the second line.");
            }
            else
            {
                Console.WriteLine("The first line is shorter than the second line.");
            }

            Console.ReadLine();
        }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Line : IComparable<Line>
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public int CompareTo(Line other)
        {
            int length1 = CalculateLength();
            int length2 = other.CalculateLength();

            return length1.CompareTo(length2);
        }

        private int CalculateLength()
        {
            int deltaX = EndPoint.X - StartPoint.X;
            int deltaY = EndPoint.Y - StartPoint.Y;
            int lengthSquared = deltaX * deltaX + deltaY * deltaY;
            int length = (int)Math.Sqrt(lengthSquared);
            return length;
        }
    }
}