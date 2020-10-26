using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Lib.Sorting.MergeSorts
{
	public class CynferddMergeSort
	{
        private readonly int[] array;

        public CynferddMergeSort(int[] array)
        {
            this.array = array;
        }
		private void Merge(int l, int m, int r)
		{
			// Find sizes of two 
			// subarrays to be merged
			int n1 = m - l + 1;
			int n2 = r - m;

			// Create temp arrays
			int[] L = new int[n1];
			int[] R = new int[n2];
			int i, j;

			// Copy data to temp arrays
			for (i = 0; i < n1; ++i)
				L[i] = array[l + i];
			for (j = 0; j < n2; ++j)
				R[j] = array[m + 1 + j];

			// Merge the temp arrays

			// Initial indexes of first 
			// and second subarrays
			i = 0;
			j = 0;

			// Initial index of merged 
			// subarry array
			int k = l;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					array[k] = L[i];
					i++;
				}
				else
				{
					array[k] = R[j];
					j++;
				}
				k++;
			}

			// Copy remaining elements 
			// of L[] if any 
			while (i < n1)
			{
				array[k] = L[i];
				i++;
				k++;
			}

			// Copy remaining elements 
			// of R[] if any 
			while (j < n2)
			{
				array[k] = R[j];
				j++;
				k++;
			}
		}

		public void Sort()
        {
			Sort(0, array.Length - 1);
		}

		void Sort(int l, int r)
		{
			if (l < r)
			{
				// Find the middle 
				// point
				int m = (l + r) / 2;

				// Sort first and 
				// second halves
				Sort(l, m);
				Sort(m + 1, r);

				// Merge the sorted halves
				Merge(l, m, r);
			}
		}


		
	}
}