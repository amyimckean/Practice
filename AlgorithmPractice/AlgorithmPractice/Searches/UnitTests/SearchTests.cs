using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Searches.UnitTests
{
    [TestClass]
    public class SearchTests
    {
        private int[] _searchArray1 = new[] {1, 4, 3, 7, 91, 83, 74, 60, 100, 31};

        [DataRow(SearchType.BinarySearch, true, 7)]
        [DataRow(SearchType.LinearSearch, false, 5)]
        [DataTestMethod]
        public void TestSearchSuccess(SearchType searchType, bool sort, int expected)
        {
            if (sort) { Array.Sort(_searchArray1); }
            var search = GetSearchType(searchType);
            var result = search.Search(_searchArray1, 83);
            Assert.AreEqual(result, expected);
        }

        [DataRow(SearchType.BinarySearch, true)]
        [DataRow(SearchType.LinearSearch, false)]
        [DataTestMethod]
        public void TestSearchFail(SearchType searchType, bool sort)
        {
            if (sort) { Array.Sort(_searchArray1); }
            var search = GetSearchType(searchType);
            var result = search.Search(_searchArray1, 72);
            Assert.AreEqual(result, -1);
        }

        [DataRow(SearchType.BinarySearch, true, 7)]
        [DataRow(SearchType.LinearSearch, false, 5)]
        [DataTestMethod]
        public void TestRecursiveSearchSuccess(SearchType searchType, bool sort, int expected)
        {
            if (sort) { Array.Sort(_searchArray1); }
            var search = GetSearchType(searchType);
            var result = search.RecursiveSearch(_searchArray1, 83);
            Assert.AreEqual(result, expected);
        }

        [DataRow(SearchType.BinarySearch, true)]
        [DataRow(SearchType.LinearSearch, false)]
        [DataTestMethod]
        public void TestRecursiveSearchFail(SearchType searchType, bool sort)
        {
            if (sort) { Array.Sort(_searchArray1); }
            var search = GetSearchType(searchType);
            var result = search.RecursiveSearch(_searchArray1, 72);
            Assert.AreEqual(result, -1);
        }

        public ISearch GetSearchType(SearchType type)
        {
            switch (type)
            {
                case SearchType.BinarySearch:
                    return new BinarySearch();
                case SearchType.LinearSearch:
                    return new LinearSearch();
                default:
                    return null;
            }
        }
    }

    public enum SearchType {
        BinarySearch, 
        LinearSearch
    }
}
