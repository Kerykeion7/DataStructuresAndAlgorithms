using Algorithms.Lib.Sorting.MergeSorts;
using System;

namespace Algorithms.Lib.Searching.BinarySearches
{
    public static class MyBinarySearch
    {
        public static T CustomBinarySearch<T>(this T[] array, T searchKey)
        {
            array.MergeSort();
            return Find(array, searchKey);
        }

        private static T Find<T>(T[] array, T searchKey)
        {
            if (array.Length > 0)
            {
                int center = array.Length / 2;
                IComparable<T> centerValue = array[center] as IComparable<T>;

                if (centerValue.CompareTo(searchKey) == 0)
                {
                    return (T)centerValue;
                }

                if (centerValue.CompareTo(searchKey) < 0)
                {
                    T[] right = new T[array.Length - center - 1];
                    Array.Copy(array, center + 1, right, 0, array.Length - center - 1);
                    return Find(right, searchKey);
                }

                    T[] left = new T[center];
                    Array.Copy(array, 0, left, 0, center);
                    return Find(left, searchKey);
            }

            return default;
        }
    }
}
