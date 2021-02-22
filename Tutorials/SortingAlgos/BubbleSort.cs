using System;
namespace SortingAlgos
{
    public class BubbleSort
    {
        public BubbleSort()
        {
        }

        public static void Sort()
        {
            double[] listToSort = new double[] { 5, 2, 8, 1, 2, 4, 8, 8, 5, 3, 35, 76, 24, 6, 8, 4, 3, 554, 234, 56, 67 };

            Console.WriteLine("Original values: " + string.Join(",", listToSort));

            for (int i = 1; i < listToSort.Length; i++)
            {
                for(int j = 0; j < listToSort.Length - (1+i); j++)
                {
                    if(listToSort[j] > listToSort[j + 1]){
                        var temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted values: " + string.Join(",", listToSort));
        }
    }
}
