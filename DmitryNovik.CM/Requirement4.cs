using System;
using System.Linq;

namespace DmitryNovik.CM.Challenge
{
    public static class ArrayExtensions
    {
        public static int[] GetMostCommonElements(this int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            var countedElements = array.GroupBy(a => a).Select(g => new {Count = g.Count(), Element = g.Key}).ToArray();

            return countedElements.Where(g => g.Count == countedElements.Max(c => c.Count))
                .Select(g => g.Element)
                .ToArray();
        }
    }
}
