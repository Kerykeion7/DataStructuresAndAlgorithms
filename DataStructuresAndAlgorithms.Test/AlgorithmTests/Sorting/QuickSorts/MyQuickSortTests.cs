using Algorithms.Lib.Sorting.QuickSorts;
using DataStructuresAndAlgorithms.Api.Classes;
using DataStructuresAndAlgorithms.Api.Services;
using System;
using System.Linq;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.AlgorithmTests.Sorting.QuickSorts
{
    public class MyQuickSortTests
    {
        [Fact]
        public void MyQuickSortedIntArray_Equals_ExpectedSortedIntArray()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };
            int[] expected = { 1, 4, 5, 9, 17, 53, 65, 78, 80, 350 };

            int[] actual = arr.QuickSort();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortedStringArray_Equals_ExpectedSortedStringArray()
        {
            string[] arr = { "sit", "down", "on", "the", "ground", "david" };
            string[] expected = { "david", "down", "ground", "on", "sit", "the" };

            string[] actual = arr.QuickSort();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortedFloatArray_Equals_ExpectedSortedFloatArray()
        {
            float[] arr = { 5.78f, 4.333f, 80.569f, 65.216f, 9.5f, 31.325f, 458.2f, 17.9f, 1.5f, 9.49f, 53.325f };
            float[] expected = { 1.5f, 4.333f, 5.78f, 9.49f, 9.5f, 17.9f, 31.325f, 53.325f, 65.216f, 80.569f, 458.2f };

            float[] actual = arr.QuickSort();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortedCharArray_Equals_ExpectedSortedCharArray()
        {
            char[] arr = { 'd', 'z', 'w', '3', 'f', 'z', 'g', 'b', 't' };
            char[] expected = { '3', 'b', 'd', 'f', 'g', 't', 'w', 'z', 'z' };

            char[] actual = arr.QuickSort();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortTestClassOneArray_Equals_ExpectedSortedByIdArray()
        {
            TestClassOne[] arr = TestClassOneService.GenerateTestClassOnesArray();
            TestClassOne[] expected = arr.OrderBy(t => t.Id).ToArray();

            TestClassOne[] actual = arr.QuickSortBy(t => t.Id);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortTestClassOneArray_Equals_ExpectedSortedByNameArray()
        {
            TestClassOne[] arr = TestClassOneService.GenerateTestClassOnesArray();
            TestClassOne[] expected = arr.OrderBy(t => t.Name).ToArray();

            TestClassOne[] actual = arr.QuickSortBy(t => t.Name);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyQuickSortTestClassOneArray_Equals_ExpectedSortedByDateArray()
        {
            TestClassOne[] arr = TestClassOneService.GenerateTestClassOnesArray();
            TestClassOne[] expected = arr.OrderBy(t => t.Date).ToArray();

            TestClassOne[] actual = arr.QuickSortBy(t => t.Date);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void QuickSortCall_Throws_ArgumentException()
        {
            TestClassOne[] arr = TestClassOneService.GenerateTestClassOnesArray();

            Assert.Throws<ArgumentException>(() => arr.QuickSort());
        }
    }
}
