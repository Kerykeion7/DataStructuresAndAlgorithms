using System;

namespace Algorithms.Lib.Sorting.MergeSorts
{
    public class PdelcoMergeSort<T> where T : IComparable<T>
    {
        public static void MergeSort(T[] info, int first, int last)
        {
            int middle;

            if (first < last)
            {
                middle = ((first + last) / 2);

                MergeSort(info, first, middle);

                MergeSort(info, middle + 1, last);

                Merge(info, first, middle, middle + 1, last);
            }
        }

        private static void Merge(T[] info, int leftFirst, int leftLast, int rightFirst, int rightLast)
        {
            T[] tempArray = new T[info.Length];
            int index = leftFirst;
            int saveFirst = leftFirst;

            while (leftFirst <= leftLast && rightFirst <= rightLast)
            {
                if (info[leftFirst].CompareTo(info[rightFirst]) < 0)
                {
                    tempArray[index] = info[leftFirst];
                    leftFirst++;
                }
                else
                {
                    tempArray[index] = info[rightFirst];
                    rightFirst++;
                }
                index++;
            }

            while (leftFirst <= leftLast)
            {
                tempArray[index] = info[leftFirst];
                leftFirst++;
                index++;
            }

            while (rightFirst <= rightLast)
            {
                tempArray[index] = info[rightFirst];
                rightFirst++;
                index++;
            }

            index = saveFirst;

            while (index <= rightLast)
            {
                info[index] = tempArray[index];
                index++;
            }
        }
    }
}
