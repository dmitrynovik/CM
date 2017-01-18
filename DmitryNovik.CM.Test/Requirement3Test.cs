using System;
using NUnit.Framework;

namespace DmitryNovik.CM.Challenge.Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void When_Edge_Non_Positive_Throws_Exception()
        {
            Assert.Throws<InvalidTriangleException>(() => new Triangle(0, 1, 2));
        }

        [Test]
        public void When_Triangle_Inequality_Broken_Throws_Exception()
        {
            Assert.Throws<InvalidTriangleException>(() => new Triangle(1, 1, 10));
        }

        [Test]
        public void When_Triangle_IsValid_TheArea_Is_Calculated_Correctly()
        {
            var t = new Triangle(3, 4, 5);
            Assert.AreEqual(6, t.CalculateArea());
        }

        [Test]
        public void When_Triangle_IsValid_With_FloatingPoint_Edges_TheArea_Is_Calculated_Correctly()
        {
            var t = new Triangle(3, 3, 3);
            Assert.AreEqual(3.9, Math.Round(t.CalculateArea(), 1));
        }
    }
}
