using System;
namespace SearchingAlgos
{
    public class BinarySearch
    {
        int[] sortedArray;

        public BinarySearch()
        {
            sortedArray = new int[15] { 3,7,9,12,24,56,78,90,123,145,234,256,456,487,526}; 
        }

        //the array should be sorted
        //O(log(n)
        public bool BinarySearchRec(int x)
        {            
            return BinarySearchRecursive(x, 0, sortedArray.Length);
        }

        private bool BinarySearchRecursive(int x, int left, int right)
        {
            if(left > right)
            {
                return false;
            }
            int mid = (left + right) / 2;

            if(x == sortedArray[mid])
            {
                return true;
            }
            else if(x < sortedArray[mid])
            {
                return BinarySearchRecursive( x, left, mid - 1);
            }
            else
            {
                return BinarySearchRecursive(x, mid + 1, right);
            }
        }

        public bool BinarySearchIterative(int x)
        {
            if(sortedArray.Length == 0)
            {
                return false;
            }

            int left = 0;
            int right = sortedArray.Length - 1;
            
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (x == sortedArray[mid])
                {
                    return true;
                }
                else if(x < sortedArray[mid])
                {
                    right = mid - 1;                  
                    
                }
                else
                {
                    left = mid + 1;                   
                    
                }
            }

            return false;
        }
    }
}
