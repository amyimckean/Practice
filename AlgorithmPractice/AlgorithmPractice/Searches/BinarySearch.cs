using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Searches
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] arr, int findMe)
        {
            var max = arr.Length - 1;
            var min = 0;

            while (max >= min)
            {
                var mid = (int)((max + min) / 2);
                if (arr[mid] == findMe)
                {
                    return mid;
                }
                else if (arr[mid] > findMe)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public int RecursiveSearch(int[] arr, int findMe)
        {
            var max = arr.Length - 1;
            var min = 0;
            return RecursiveSearchWork(arr, findMe, max, min);
        }

        private int RecursiveSearchWork(int[] arr, int findMe, int max, int min)
        {
            if (max >= min)
            {
                var mid = (int) ((max + min) / 2);
                if (arr[mid] == findMe)
                {
                    return mid;
                }

                return arr[mid] > findMe ? RecursiveSearchWork(arr, findMe, mid - 1, min) : RecursiveSearchWork(arr, findMe, max, mid + 1);
            }

            return -1;
        }
    }
}
