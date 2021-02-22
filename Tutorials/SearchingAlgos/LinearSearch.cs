using System;
namespace SearchingAlgos
{
    public class LinearSearch
    {
        public LinearSearch()
        {
        }

        private bool Search(int[] array, int x)
        {
            for(int i = 0; i < array.Length; i ++)
            {
                if (array[i] == x)
                    return true;
            }
            return false;
        }

        public void PerformLinearSearch(int x)
        {
            int[] listToSearch = new int[] { 5, 2, 8, 1, 2, 4, 8, 8, 5, 3, 35, 76, 24, 6, 8, 4, 3, 554, 234, 56, 67 };

            Console.WriteLine("Original values: " + string.Join(",", listToSearch));

            bool isPresent = Search(listToSearch, x);

            Console.WriteLine(isPresent);
        }

    }
}
