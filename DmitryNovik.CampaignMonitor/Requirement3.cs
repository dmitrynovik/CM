using System;

namespace DmitryNovik.CampaignMonitor
{
    public static class Triangle
    {
        public static double CalculateArea(int a, int b, int c)
        {
            Validate(a, b, c);

            // see http://en.wikipedia.org/wiki/Triangle#Using_Heron.27s_formula
            var s = (a+b+c) / (double)2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private static void Validate(int a, int b, int c)
        {
            var sortedEdges = new[] { a, b, c };
            Array.Sort(sortedEdges);

            if (sortedEdges[0] <= 0) 
                throw new InvalidTriangleException("Triangle edges must be positive numbers");

            if (sortedEdges[0] + sortedEdges[1] <= sortedEdges[2])
            {
                // see http://en.wikipedia.org/wiki/Triangle_inequality
                throw new InvalidTriangleException("The triangle is not valid: the longest edge should be smaller than the sum of other two.");
            }
        }
    }

    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string message) : base(message) { }
    }
}
