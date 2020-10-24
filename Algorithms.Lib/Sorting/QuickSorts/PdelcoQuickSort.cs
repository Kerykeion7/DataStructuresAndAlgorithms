using Algorithms.Lib.Helpers;
using Algorithms.Lib.Sorting.Helpers;
using DataStructures.Lib.Arrays;
using System;
using System.Threading;

namespace Algorithms.Lib.Sorting.QuickSorts
{
    public static class PdelcoQuickSort<T> where T : IComparable<T>
    {
        public static void QuickSort(T[] list, int start, int end)
        {
            if (start < end)
            {
                Split(list, start, end, out int split1, out int split2);
                if (split1 < end)
                    QuickSort(list, split1, end);
                if (start < split2)
                    QuickSort(list, start, split2);
            }
        }

        private static void Split(T[] list, int start, int end, out int split1, out int split2)
        {
            T value = list[start + end / 2];

            while (start < end)
            {
                while (value.CompareTo(list[start]) < 0)
                {
                    start++;
                }

                while (value.CompareTo(list[end]) > 0)
                {
                    end--;
                }

                if (start <= end)
                {
                    Swap(list[start], list[end]);
                    start++;
                    end--;
                }
            }
            split1 = start;
            split2 = end;
        }

        private static void Swap(T element1, T element2)
        {
            T temp = element1;
            element1 = element2;
            element2 = temp;
        }
    }
}
