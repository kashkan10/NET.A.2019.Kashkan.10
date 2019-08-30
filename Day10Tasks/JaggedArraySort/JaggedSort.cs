using System;
using System.Collections.Generic;

namespace JaggedArraySort
{
    public class JaggedSort
    {
        /// <summary>
        /// Comparison method with IComparer as parameter
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="comparer"></param>
        public void Compare(int[][] arr, IComparer<int[]> comparer)
        {
            Sort(arr, comparer.Compare);
        }

        /// <summary>
        /// Comparison method with delegate as parameter
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <param name="comparer">Second array</param>
        public void Sort(int[][] arr, Comparison<int[]> comparer)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer(arr[i], arr[j]) > 0)
                    {
                        int[] swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
        }
    }
}
