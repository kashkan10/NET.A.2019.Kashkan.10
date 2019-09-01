using JaggedArraySort;
using JaggedArraySort.Comparers;
using NUnit.Framework;

namespace JaggedArraySortTests
{
    public class JaggedSortBTests
    {
        [Test]
        public void SumOfSortTest()
        {
            int[][] array = new int[4][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 3, 4, 5 }
            };

            int[][] expected = new int[4][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }
            };

            JaggedSortB.Sort(array, new SumOfSort().Compare);
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void MinOfSortTest()
        {
            int[][] array = new int[4][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7, 8 },
                new int[] { 0, 1, 2 },
                new int[] { 1, 2, 3, 4, 5, 9 }
            };

            int[][] expected = new int[4][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5, 9 },
                new int[] { 4, 5, 6, 7, 8 },
            };

            JaggedSortB.Sort(array, new MinOfSort().Compare);
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void MaxOfSortTest()
        {
            int[][] array = new int[4][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 3, 4, 5, 9 }
            };

            int[][] expected = new int[4][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
                new int[] { 1, 2, 3, 4, 5, 9 }
            };

            JaggedSortB.Sort(array, new MaxOfSort().Compare);
            Assert.AreEqual(array, expected);
        }
    }
}
