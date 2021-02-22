using System;

namespace SortingAlgos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //InsertionSort.Sort();

            //BubbleSort.Sort();

            //PerformMergeSort();

            PerformQuickSort();
        }

        public static void PerformMergeSort()
        {
            var ms = new MergeSort();
            ms.PerformMergeSort();
        }

        public static void PerformQuickSort()
        {
            var qs = new QuickSort();
            qs.PerformQuickSort();
        }
    }
}
