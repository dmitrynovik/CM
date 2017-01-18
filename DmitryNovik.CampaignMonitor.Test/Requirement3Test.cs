using System;
using NUnit.Framework;

namespace DmitryNovik.CampaignMonitor.Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void When_Edge_Non_Positive_Throws_Exception()
        {
            Assert.Throws<InvalidTriangleException>(() => Triangle.CalculateArea(0, 1, 2));
        }

        [Test]
        public void When_Triangle_Inequality_Broken_Throws_Exception()
        {
            Assert.Throws<InvalidTriangleException>(() => Triangle.CalculateArea(1, 1, 10));
        }

        [Test]
        public void When_Triangle_IsValid_TheArea_Is_Calculated_Correctly()
        {
            var result = Triangle.CalculateArea(3, 4, 5);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void When_Triangle_IsValid_With_FloatingPoint_Edges_TheArea_Is_Calculated_Correctly()
        {
            var result = Triangle.CalculateArea(3, 3, 3);
            Assert.AreEqual(3.9, Math.Round(result, 1));
        }
    }
}
