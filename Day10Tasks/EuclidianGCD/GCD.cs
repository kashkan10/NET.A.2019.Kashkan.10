using System;
using System.Diagnostics;
using System.Linq;

namespace EuclidianGCD
{
    public class GCD
    {
        public delegate int GcdAlghoritm(params int[] arr);

        /// <summary>
        /// Additional method to check calculation speed of GCD method
        /// </summary>
        /// <param name="arr">Array of integer numbers.</param>
        /// <returns>GCD of numbers</returns>
        public static int TimeOfGCD(GcdAlghoritm gcd, params int[] arr)
        {
            Stopwatch time = Stopwatch.StartNew();
            int result = gcd(arr);
            time.Stop();
            Console.WriteLine(time.Elapsed.TotalMilliseconds);
            return result;
        }

        /// <summary>
        /// Euclidian method of searching GCD
        /// </summary>
        /// <param name="arr">Array of integer numbers.</param>
        /// <returns>GCD of numbers</returns>
        public static int GCDEuclid(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = arr.Max();
                }

                arr[i] = Math.Abs(arr[i]);
            }

            int min = arr.Min();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % min != 0)
                {
                    arr[i] %= min;
                }
                else
                {
                    count++;
                }
            }

            if (count == arr.Length)
            {
                return Math.Abs(min);
            }

            return GCDEuclid(arr);
        }

        /// <summary>
        /// Searching GCD of 1, 2, etc numbers with Steins algorithm
        /// </summary>
        /// <param name="arr">Array of integer numbers.</param>
        /// <returns>GCD of numbers</returns>
        public static int GCDStein(params int[] arr)
        {
            int a = Math.Abs(arr.First());
            int i = 1;
            while (i < arr.Length)
            {
                a = SteinAlgorithm(a, Math.Abs(arr[i++]));
            }

            return a;
        }

        /// <summary>
        /// Stein's algorithm for two numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="a">Second number</param>
        /// <returns>GCD of numbers</returns>
        private static int SteinAlgorithm(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a == 1 || b == 1)
            {
                return 1;
            }

            if ((a & 1) == 0)
            {
                if ((b & 1) == 0)
                {
                    return SteinAlgorithm(a >> 1, b >> 1) << 1;
                }
                else
                {
                    return SteinAlgorithm(a >> 1, b);
                }
            }
            else
            {
                if ((b & 1) == 0)
                {
                    return SteinAlgorithm(a, b >> 1);
                }
                else
                {
                    return a > b ? SteinAlgorithm((a - b) >> 1, b) : SteinAlgorithm((b - a) >> 1, a);
                }
            }
        }
    }
}
