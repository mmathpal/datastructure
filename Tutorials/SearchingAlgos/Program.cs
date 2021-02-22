using System;

namespace SearchingAlgos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //BinarySearch();
            //BinarySearchIterative();

            LinearSearch();
        }

        public static void BinarySearch()
        {
            var bs = new BinarySearch();
            Console.WriteLine(bs.BinarySearchRec(56));
        }

        public static void BinarySearchIterative()
        {
            var bs = new BinarySearch();
            Console.WriteLine(bs.BinarySearchIterative(56));
        }

        public static void LinearSearch()
        {
            var ls = new LinearSearch();
            ls.PerformLinearSearch(56);
        }
    }
}
