using System;
namespace SortingAlgos
{
    public class InsertionSort
    {
        public InsertionSort()
        {
        }

        public static void Sort()
        {
            double[] listToSort = new double[] { 5, 2, 8, 1, 2, 4, 8, 8, 5, 3 , 35,76,24,6,8,4,3,554,234,56,67};

            Console.WriteLine("Original values: " + string.Join(",", listToSort));

            for(int i = 1; i < listToSort.Length; i++)
            {     
                int j = i;
                while (j > 0 && listToSort[j - 1] > listToSort[j]){
                    double temp = listToSort[j];
                    listToSort[j] = listToSort[j-1]; 
                    listToSort[j - 1] = temp;

                    j--;
                }
            }

            Console.WriteLine("Sorted values: " + string.Join(",", listToSort));
        }
    }
}
