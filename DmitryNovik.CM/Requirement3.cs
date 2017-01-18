using System;

namespace DmitryNovik.CM.Challenge
{
    public class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            Validate(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double CalculateArea()
        {
            // see http://en.wikipedia.org/wiki/Triangle#Using_Heron.27s_formula
            var s = (A+B+C) / (double)2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
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
