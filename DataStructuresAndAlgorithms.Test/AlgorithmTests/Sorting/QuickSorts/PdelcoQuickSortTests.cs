using Algorithms.Lib.Sorting.QuickSorts;
using DataStructuresAndAlgorithms.Api.Services;
using DataStructuresAndAlgorithms.Test.Classes;
using System;
using System.Linq;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.AlgorithmTests.Sorting.QuickSorts
{
      public class PdelcoQuickSortTests
    {
        [Fact]
        public void PdelcoQuickSortedIntArray_Equals_ExpectedSortedIntArray()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };
            int[] expected = { 1, 4, 5, 9, 17, 53, 65, 78, 80, 350 };

            int[] actual = arr.QuickSort();

            Assert.Equal(expected, actual);
 
        }

        [Fact]
        public void Test1()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };
            int[] expected = { 1, 4, 5, 9, 17, 53, 65, 78, 80, 350 };

            PdelcoQuickSort<int>.QuickSort(arr, 0, arr.Length -1);

            Assert.Equal(expected, arr);
        }
    }
}