using System;

namespace Algorithms.Lib.Sorting.QuickSorts
{
    public static class PdelcoQuickSort<T> where T: IComparable<T>
    {
        public static void QuickSort(T[] items, int start, int end)
        {
            if (start < end)
            {
                Split(items, start, end,  out int splitPart1, out int splitPart2);
                if (splitPart1 < end)
                    QuickSort(items, splitPart1, end);

                if (start < splitPart2)
                    QuickSort(items, start, splitPart2);
            }
        }

        private static void Split(T[] items, int start, int end, out int splitPart1, out int splitPart2)
        {
            T element = items[(start + end) / 2];

            do
            {
                while (items[start].CompareTo(element) < 0)
                    start++;

                while (items[end].CompareTo(element) > 0)
                    end--;

                if (start <= end)
                {
                    Swap(ref items[start], ref items[end]);
                    start++;
                    end--;
                }
            }
            while (start < end);

            splitPart1 = start;
            splitPart2 = end;
        }

        private static void Swap(ref T element1, ref T element2)
        {
            T temp = element1;
            element1 = element2;
            element2 = temp;
        }
    }

}
