using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySort.Comparers
{
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
}
