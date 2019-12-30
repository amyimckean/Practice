using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Sorts
{
    class BubbleSort : ISort
    {
        public void Sort(int[] arr)
        {
            var sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (var i = 0; i < arr.Length - 1; ++i)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }

        public void RecursiveSort(int[] arr)
        {
            RecursiveSortWork(arr, arr.Length);
        }

        private void RecursiveSortWork(int[] arr, int iteration)
        {
            if (iteration == 1)
            {
                return;
            }

            for (var i = 0; i < iteration - 1; ++i)
            {
                if (arr[i + 1] < arr[i])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }

                RecursiveSortWork(arr, iteration - 1);
            }
        }
    }
}
