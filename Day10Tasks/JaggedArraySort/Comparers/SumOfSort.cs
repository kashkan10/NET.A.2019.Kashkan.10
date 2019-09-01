using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySort.Comparers
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
}
