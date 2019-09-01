using System;
using System.Collections.Generic;

namespace JaggedArraySort
{
    public static class JaggedSortB
    {
        /// <summary>
        /// Sort method with IComparer as parameter
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="comparer"></param>
        public static void Compare(int[][] arr, IComparer<int[]> comparer)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) > 0)
                    {
                        int[] swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
        }

        /// <summary>
        /// Sort method with delegate as parameter
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="comparer">Second array</param>
        public static void Sort(int[][] arr, Comparison<int[]> comparer)
        {
            Compare(arr, ComparerAdapter.Create(comparer));
        }
    }
}
