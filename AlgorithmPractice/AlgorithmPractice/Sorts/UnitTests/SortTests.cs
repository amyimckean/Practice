using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Sorts.UnitTests
{
    [TestClass]
    public class SortTests
    {

        [DataRow(SortType.BubbleSort, new[] { 1, 4, 3, 7, 91, 83, 74, 60, 100, 31 }, new[] { 1, 4, 3, 7, 91, 83, 74, 60, 100, 31 })]
        [DataRow(SortType.BubbleSort, new[] { 12, 1, 33, 2, 91, 83, 74, 60, 98, 34, 4}, new[] { 12, 1, 33, 2, 91, 83, 74, 60, 98, 34, 4 })]
        [DataTestMethod]
        public void TestSortSuccess(SortType sortType, int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            var sort = GetSort(sortType);
            sort.Sort(arr2);
            CollectionAssert.AreEqual(arr1, arr2);

        }

        [DataRow(SortType.BubbleSort, new[] { 1, 4, 3, 7, 91, 83, 74, 60, 100, 31 }, new[] { 1, 4, 3, 7, 91, 83, 74, 60, 100, 31 })]
        [DataRow(SortType.BubbleSort, new[] { 12, 1, 33, 2, 91, 83, 74, 60, 98, 34, 4 }, new[] { 12, 1, 33, 2, 91, 83, 74, 60, 98, 34, 4 })]
        [DataTestMethod]
        public void TestRecursiveSortSuccess(SortType sortType, int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            var sort = GetSort(sortType);
            sort.RecursiveSort(arr2);
            CollectionAssert.AreEqual(arr1, arr2);

        }

        private ISort GetSort(SortType type)
        {
            switch (type)
            {
                case SortType.BubbleSort:
                    return new BubbleSort();
                default:
                    return new BubbleSort();
            }
        }
    }

    public enum SortType
    {
        BubbleSort
    }
}
    