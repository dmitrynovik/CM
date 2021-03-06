﻿using System;
using System.Collections.Generic;

namespace DmitryNovik.CM.Challenge
{
    public static class NumberExtensions
    {
        public static IEnumerable<int> GetAllPositiveDivisors(this int n)
        {
            if (n <= 0)
                throw new ArgumentException("The input must be a positive number", nameof(n));

            // iterate till half-number in search of divisors since a divisor (except self) never greater than N / 2:
            for (int i = 1; i <= n / 2 + 1; ++i)
            {
                if (n % i == 0)
                    yield return i;
            }

            if (n > 2)
                yield return n;
        }
    }
}
