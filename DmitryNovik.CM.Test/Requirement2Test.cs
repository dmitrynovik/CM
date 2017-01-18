using System;
using System.Linq;
using NUnit.Framework;

namespace DmitryNovik.CM.Challenge.Test
{
    [TestFixture]
    public class NumberExtensionsTest
    {
        [Test]
        public void When_Negative_Throws_ArgumentException()
        {
            int num = -1;
            Assert.Throws<ArgumentException>(() => num.GetAllPositiveDivisors().ToArray());
        }

        [Test]
        public void When_Zero_Throws_ArgumentException()
        {
            int num = 0;
            Assert.Throws<ArgumentException>(() => num.GetAllPositiveDivisors().ToArray());
        }

        [Test]
        public void When_Prime_Returns_Only_1_And_Self()
        {
            int num = 13;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 13 }));
        }

        [Test]
        public void When_1_Returns_1()
        {
            int num = 1;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1 }));
        }

        [Test]
        public void When_2_Returns_1_2()
        {
            int num = 2;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 2 }));
        }

        [Test]
        public void When_Even_And_Positive_Returns_Expected_Divisors()
        {
            int num = 6;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 2, 3, 6 }));
        }

        [Test]
        public void When_Odd_And_Positive_Returns_Expected_Divisors()
        {
            int num = 15;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 3, 5, 15 }));
        }

        [Test]
        public void Test_42()
        {
            int num = 42;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 2, 3, 6, 7, 14, 21, 42 }));
        }

        [Test]
        public void Test_60()
        {
            int num = 60;
            var result = GetDivisorsOf(num);
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 }));
        }

        [Test]
        public void Result_Contains_Unique_Divisors_Only()
        {
            int num = 15;
            var result = GetDivisorsOf(num);
            Assert.AreEqual(result.Length, result.Distinct().Count());
        }

        private static int[] GetDivisorsOf(int num)
        {
            return num.GetAllPositiveDivisors().OrderBy(i => i).ToArray();
        }
    }
}
