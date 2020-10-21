using Algorithms.Lib.Searching.BinarySearches;
using DataStructuresAndAlgorithms.Api.Classes;
using DataStructuresAndAlgorithms.Api.Services;
using System;
using System.Linq;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.AlgorithmTests.Searching.BinarySearches
{
    public class MyBinarySearchTests
    {
        [Fact]
        public void MyBinarySearch_Equals_One()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };

            int key = arr.CustomBinarySearch(1);

            Assert.Equal(1, key);
        }

        [Fact]
        public void MyBinarySearch_Returns_0()
        {
            int[] arr = { 350, 78, 5, 4, 80, 65, 17, 1, 9, 53 };

            int key = arr.CustomBinarySearch(3);

            Assert.Equal(0, key);
        }

        [Fact]
        public void MergeSortCall_Throws_ArgumentException()
        {
            TestClassOne[] arr = TestClassOneService.GenerateTestClassOnesArray();

            Assert.Throws<ArgumentException>(() => arr.CustomBinarySearch(arr.First()));
        }
    }
}
