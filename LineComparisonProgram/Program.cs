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
            // Initialize variables
            int x1, y1, x2, y2, deltaX, deltaY, lengthSquared, length;
            Console.WriteLine("Welcome to Line Comparison Program");
            // Input two points
            Console.WriteLine("Enter the first point (x1, y1):");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second point (x2, y2):");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            // Calculate the length of the line
            deltaX = x2 - x1;
            deltaY = y2 - y1;
            lengthSquared = deltaX * deltaX + deltaY * deltaY;
            length = (int)Math.Sqrt(lengthSquared);
            // Output the result
            Console.WriteLine($"The length of the line is {length}");
            Console.ReadLine();
        }
    }

}