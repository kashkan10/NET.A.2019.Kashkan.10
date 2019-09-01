using System;
using System.Collections.Generic;

namespace JaggedArraySort
{
    internal class ComparerAdapter
    {
        public static IComparer<int[]> Create(Comparison<int[]> comparer)
        {
            return new DelegateComparer(comparer);
        }

        private class DelegateComparer : IComparer<int[]>
        {
            private readonly Comparison<int[]> _comparer;

            public DelegateComparer(Comparison<int[]> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(int[] x, int[] y)
            {
                return _comparer(x, y);
            }
        }
    }
}
