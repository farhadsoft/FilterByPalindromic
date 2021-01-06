﻿using System;
using System.Collections.Generic;

namespace FilterByPalindromicTask
{
    /// <summary>
    /// Provides static method for working with integers array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns new array that contains only palindromic numbers from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of elements that are palindromic numbers.</returns>
        /// <exception cref="ArgumentNullException">Throw when array is null.</exception>
        /// <exception cref="ArgumentException">Throw when array is empty.</exception>
        /// <example>
        /// {12345, 1111111112, 987654, 56, 1111111, -1111, 1, 1233321, 70, 15, 123454321}  => { 1111111, 123321, 123454321 }
        /// {56, -1111111112, 987654, 56, 890, -1111, 543, 1233}  => {  }.
        /// </example>
        public static int[] FilterByPalindromic(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"Throw when array is null. {nameof(source)}");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException($"Throw when array is empty. {nameof(source)}");
            }

            List<int> result = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                int number = source[i];
                int remineder, sum = 0;
                int temp = number;
                while (number > 0)
                {
                    remineder = number % 10;
                    sum = (sum * 10) + remineder;
                    number /= 10;
                }

                if (temp == sum)
                {
                    result.Add(temp);
                }
            }

            return result.ToArray();
        }
    }
}
