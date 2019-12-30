using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Searches
{
    public interface ISearch
    {
        int Search(int[] arr, int findMe);

        int RecursiveSearch(int[] arr, int findMe);
    }
}
