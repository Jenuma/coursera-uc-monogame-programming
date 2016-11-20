/* ProgrammingAssignment1
 * 
 * Author: Clifton Roberts
 * Date: 12 November 2016
 */

using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A console application that prompts the user for two different points on a
    /// coordinate plane and calculates the distance and angle (in degrees) between them.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            // Print welcome message and program's purpose.
            Console.WriteLine("Welcome. This application will calculate the distance " +
                "between two points and the angle between those points.");
            Console.WriteLine();

            // Get the points from the user.
            Console.Write("Enter the x value for the first point: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y value for the first point: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the x value for the second point: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y value for the second point: ");
            double y2 = double.Parse(Console.ReadLine());
            
            // Calculate the horizontal and vertical deltas between the points.
            double xDelta = x2 - x1;
            double yDelta = y2 - y1;

            // Calculate the distance and angle (in degrees) between the points.
            double distance = Math.Sqrt(Math.Pow(xDelta, 2) + Math.Pow(yDelta, 2));
            double angleRad = Math.Atan2(yDelta, xDelta);
            double angleDeg = angleRad * (180 / Math.PI);

            // Output the distance and angle (in degrees) to the user.
            Console.WriteLine();
            Console.WriteLine("Distance between the two points: {0:F3}", distance);
            Console.WriteLine("Angle between the two points: {0:F3} degrees", angleDeg);
        }
    }
}
