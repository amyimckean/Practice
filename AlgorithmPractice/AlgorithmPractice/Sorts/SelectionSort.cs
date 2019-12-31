using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Sorts
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                var minI = i;
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[j] < arr[minI])
                    {
                        minI = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[minI];
                arr[minI] = temp;
            }
        }

        public void RecursiveSort(int[] arr)
        {
            RecursiveSortWork(arr, arr.Length, 0);
        }

        private void RecursiveSortWork(int[] arr, int length, int index)
        {
            if (index == length)
            {
                return;
            }

            for (var i = index + 1; i < length; ++i)
            {
                if (arr[i] < arr[index])
                {
                    var temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                }
            }
            RecursiveSortWork(arr, length, index + 1);
        }
    }
}
