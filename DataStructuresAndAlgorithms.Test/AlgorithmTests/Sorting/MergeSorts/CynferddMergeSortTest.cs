using Algorithms.Lib.Sorting.MergeSorts;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.AlgorithmTests.Sorting.MergeSorts
{
    public class CynferddMergeSortTest
    {
        [Fact]
        public void ShouldHaveMergedArray_WhenGivenUnsortedArray()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };
            int[] expected = { 1, 4, 5, 9, 17, 53, 65, 78, 80, 350 };

            CynferddMergeSort merge = new CynferddMergeSort(arr);
            merge.Sort();

            Assert.Equal(expected, arr);
        }

    }
}
