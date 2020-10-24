using Algorithms.Lib.Sorting.QuickSorts;
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

            PdelcoQuickSort<int>.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void PdelcoQuickSortedIntArray_Equals_ExpectedSortedCharMixedCaseArray()
        {
            char[] arr = { 's', 'D', 'l', 'P', 'V', 'E', 'a', 'F', 'U', 'C' };
            char[] expected = { 'C', 'D', 'E', 'F', 'P', 'U', 'V', 'a', 'l', 's' };

            PdelcoQuickSort<char>.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void PdelcoQuickSortedIntArray_Equals_ExpectedSortedCharLowerCaseArray()
        {
            char[] arr = { 's', 'd', 'l', 'p', 'v', 'e', 'a', 'f', 'u', 'c' };
            char[] expected = { 'a', 'c', 'd', 'e', 'f', 'l', 'p', 's', 'u', 'v' };

            PdelcoQuickSort<char>.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void PdelcoQuickSortedIntArray_Equals_ExpectedSortedCharUpperCaseArray()
        {
            char[] arr = { 'S', 'D', 'L', 'P', 'V', 'E', 'A', 'F', 'U', 'C' };
            char[] expected = { 'A', 'C', 'D', 'E', 'F', 'L', 'P', 'S', 'U', 'V' };

            PdelcoQuickSort<char>.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void PdelcoQuickSortedIntArray_Equals_ExpectedSortedStringArray()
        {
            string[] arr = { "abc", "ced", "xyz", "mno", "ghi", "def", "pqr", "bcd", "stu", "jkl" };
            string[] expected = { "abc", "bcd", "ced", "def", "ghi", "jkl", "mno", "pqr", "stu", "xyz" };

            PdelcoQuickSort<string>.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }
    }
}