using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, a1, b1, a2, b2;
            Console.WriteLine("Welcome to Line Comparison Program");
            Console.WriteLine("Enter the first line coordinates (x1, y1, x2, y2):");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length1 = CalculateLength(x1, y1, x2, y2);
            Console.WriteLine("Enter the second line coordinates (a1, b1, a2, b2):");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            int length2 = CalculateLength(a1, b1, a2, b2);

            if (length1 == length2)
            {
                Console.WriteLine("The two lines are equal in length.");
            }
            else if(length1>length2)
            {
                Console.WriteLine("The first line is greater than second .");
            }
            else
            {
                Console.WriteLine("The first line is shorter than second .");
            }
            Console.ReadLine();
        }

        static int CalculateLength(int x1, int y1, int x2, int y2)
        {
            int deltaX = x2 - x1;
            int deltaY = y2 - y1;
            int lengthSquared = deltaX * deltaX + deltaY * deltaY;
            int length = (int)Math.Sqrt(lengthSquared);
            return length;
        }
    }
}