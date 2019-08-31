using JaggedArraySort;
using NUnit.Framework;

namespace Tests
{
    public class Tests
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

            array.Compare(new SumOfSort());
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

            array.Compare(new MinOfSort());
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

            array.Compare(new MaxOfSort());
            Assert.AreEqual(array, expected);
        }
    }
}