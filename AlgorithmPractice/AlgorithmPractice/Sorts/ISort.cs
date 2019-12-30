using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Sorts
{
    public interface ISort
    {
        void Sort(int[] arr);

        void RecursiveSort(int[] arr);
    }
}
