using System;
namespace SortingAlgos
{
    public class MergeSort
    {
        public MergeSort()
        {
            
        }

        private void MergeSortRecursive(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if(leftStart >= rightEnd)
            {
                return;
            }

            int middle = (leftStart + rightEnd) / 2;
            MergeSortRecursive(array, temp, leftStart, middle);
            MergeSortRecursive(array, temp, middle + 1, rightEnd);

            MergeHalves(array, temp, leftStart, rightEnd);

        }

        private void MergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while(left <= leftEnd && right <= rightEnd)
            {
                if(array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                }
                else
                {
                    temp[index] = array[right];
                    right++;
                }
                index++;
            }

            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, size);

        }

        public void PerformMergeSort()
        {
            int[] listToSort = new int[] { 5, 2, 8, 1, 2, 4, 8, 8, 5, 3, 35, 76, 24, 6, 8, 4, 3, 554, 234, 56, 67 };
            int[] temp = new int[listToSort.Length];

            Console.WriteLine("Original values: " + string.Join(",", listToSort));

            MergeSortRecursive(listToSort, temp, 0, listToSort.Length - 1);

            Console.WriteLine("Sorted values: " + string.Join(",", listToSort));
        }
    }

    
}
