﻿using System;
using System.Linq;
using NUnit.Framework;

namespace DmitryNovik.CampaignMonitor.Test
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
            var result = num.GetAllPositiveDivisors().ToArray();
            Assert.Contains(1, result);
            Assert.Contains(13, result);
        }

        [Test]
        public void When_Even_And_Positive_Returns_Expected_Divisors()
        {
            int num = 6;
            var result = num.GetAllPositiveDivisors().ToArray();
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(3, result);
            Assert.Contains(6, result);
        }

        [Test]
        public void When_Odd_And_Positive_Returns_Expected_Divisors()
        {
            int num = 15;
            var result = num.GetAllPositiveDivisors().ToArray();
            Assert.Contains(1, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(15, result);
        }

        [Test]
        public void Contains_Unique_Divisors_Only()
        {
            int num = 15;
            var result = num.GetAllPositiveDivisors();
            Assert.AreEqual(result.Count(), result.Distinct().Count());
        }
    }
}
