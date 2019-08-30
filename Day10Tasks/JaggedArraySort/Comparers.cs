using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySort
{
    public class SumOfSort : IComparer<int[]>
    {
        /// <summary>
        /// IComparer implementation(sum of elements)
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>result</returns>
        public int Compare(int[] a, int[] b)
        {
            return a.Sum().CompareTo(b.Sum());
        }
    }

    public class MaxOfSort : IComparer<int[]>
    {
        /// <summary>
        /// IComparer implementation(max of elements)
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>result</returns>
        public int Compare(int[] a, int[] b)
        {
            return a.Max().CompareTo(b.Max());
        }
    }

    public class MinOfSort : IComparer<int[]>
    {
        /// <summary>
        /// IComparer implementation(min of elements)
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>result</returns>
        public int Compare(int[] a, int[] b)
        {
            return a.Min().CompareTo(b.Min());
        }
    }
}
