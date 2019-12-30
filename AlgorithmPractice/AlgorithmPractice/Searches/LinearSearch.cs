using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Searches
{
    public class LinearSearch : ISearch
    {
        public int Search(int[] arr, int findMe)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                if (arr[i] == findMe)
                {
                    return i;
                }
            }

            return -1;
        }

        public int RecursiveSearch(int[] arr, int findMe)
        {
            return RecursiveSearchWork(arr, findMe, arr.Length - 1, 0);
        }

        private int RecursiveSearchWork(int[] arr, int findMe, int max, int min)
        {
            if (max < min)
            {
                return -1;
            }

            if (arr[max] == findMe)
            {
                return max;
            }

            return arr[min] == findMe ? min : RecursiveSearchWork(arr, findMe, max - 1, min + 1);
        }
    }
}
