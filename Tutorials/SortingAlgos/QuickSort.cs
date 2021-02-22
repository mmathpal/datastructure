using System;
namespace SortingAlgos
{
    public class QuickSort
    {
        public QuickSort()
        {
        }

        private void Sort(int[] array, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            Sort(array, left, index - 1);
            Sort(array, index, right);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        public void PerformQuickSort()
        {
            int[] listToSort = new int[] { 5, 2, 8, 1, 2, 4, 8, 8, 5, 3, 35, 76, 24, 6, 8, 4, 3, 554, 234, 56, 67 };

            Console.WriteLine("Original values: " + string.Join(",", listToSort));

            Sort(listToSort, 0, listToSort.Length - 1);

            Console.WriteLine("Sorted values: " + string.Join(",", listToSort));
        }
    }
}
