using System;

namespace LogicalConcepts
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            //PrintLongestUniformSubstring();
            //PrintFirstNonRepeatingCharInStringUsingList();
            //PrintSecondSmallest();
            //PrintFibonacciSeries();
            //PrintFibonacciSeriesThreeNumber();
            //PrintReverseString();
            //PrintConsecutiveRepeatingChar();
            //PrintLargestGrade();

            //ArrayLeftRotation.PerformLeftRotation();

            //ValidParentheses.IsValid("]");

            //PrintFibonacciSeriesRecursive();

            LongestSubstringWithoutRepeatingCharacters.FindNonRepeatingLongestSubstring("dvdf");

            //Console.ReadKey();
        }

        public static void PrintFibonacciSeries()
        {
            FibonacciSeries fs = new FibonacciSeries();
            fs.GenerateFibonacciSeries(20);
        }

        public static void PrintFibonacciSeriesRecursive()
        {
            FibonacciSeries fs = new FibonacciSeries();
            var ret = fs.GenerateFibonacciSeriesUsingRecursion(1);

            Console.WriteLine(ret);

        }

        public static void PrintFibonacciSeriesThreeNumber()
        {
            FibonacciSeriesForThreeNumbers fs = new FibonacciSeriesForThreeNumbers();
            fs.GenerateSeries(20);
        }

        public static void PrintSecondSmallest()
        {
            SecondSmallestInArray sm = new SecondSmallestInArray();
            int[] arr = { 12, 13, 1, 10, 34, 1 };
            var result = sm.SecondSmallestNumber(arr);

            Console.WriteLine("Second smallest number is: " + result);
        }

        public static void PrintFirstNonRepeatingCharInStringUsingList()
        {
            var fi = new FirstNonRepeatingCharInString();
            string str = "GeeksforGeeks";
            var result = fi.GetFirstNonRepeatingCharUsingList(str);

            Console.WriteLine("First non repeating char is: " + result);
        }

        public static void PrintLongestUniformSubstring()
        {
            var ss = new LongestUniformSubstring();
            ss.GetLongestUniformSubstring("aabbbkljnnngghedddddccccccqqq");
        }

        public static void PrintReverseString()
        {
            var rs = new ReverseString();
            rs.GetReverseString("Hello World!");
        }

        public static void PrintConsecutiveRepeatingChar()
        {
            var rc = new MaximumConsecutiveRepeatingChar();
            rc.MaxConsecutiveRepeatingChar("vgjuurrhtkkssshheeepppppasllmnnn");

            rc.MaxConsecutiveRepeatingCharUsingOneLoop("vgjuurrhtkkssshheeepppppasllmnnn");
        }

        public static void PrintLargestGrade()
        {
            LargestAverageGrade.GetLargestAverageGrade();
        }
    }
}
