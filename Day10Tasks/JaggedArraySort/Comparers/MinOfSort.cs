using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySort.Comparers
{
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
