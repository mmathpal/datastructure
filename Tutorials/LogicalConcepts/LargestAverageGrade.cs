using System;
using System.Collections.Generic;

namespace LogicalConcepts
{
    /*
     *Calculate the largest average grade (from 1 to 100) among a list of names and grades.
     * find average of each student and return the the name of the student with highest average.
     * */
    public class LargestAverageGrade
    {
        public static void GetLargestAverageGrade()
        {

            string[,] arr = {
                                { "Charlie", "78" },{ "Charlie", "85" },{ "Jon", "56" },{ "Garry", "97" }
                                ,{ "Garry", "87" },{ "Jon", "98" },{ "Garry", "64" },{ "Charlie", "68" },{ "Garry", "45" }};
            Dictionary<string, int> dictGrade = new Dictionary<string, int>();
            Dictionary<string, int> dictSubjectCount = new Dictionary<string, int>();

            for (int i = 0; i < arr.GetLength(0) ; i++)
            {
                if(!dictGrade.ContainsKey(arr[i,0]))
                {
                    dictGrade.Add(arr[i, 0], Convert.ToInt32(arr[i, 1]));
                    dictSubjectCount.Add(arr[i, 0], 1);
                }
                else
                {
                    dictGrade[arr[i, 0]] = dictGrade[arr[i, 0]] + Convert.ToInt32(arr[i, 1]);
                    dictSubjectCount[arr[i, 0]] = dictSubjectCount[arr[i, 0]] + 1;
                }
            }

            int average = -1;
            string studentHavingHighestAve = string.Empty;
            foreach(KeyValuePair<string,int> pair in dictGrade)
            {
                int subjectCount = dictSubjectCount[pair.Key];

                int currentAve = pair.Value / subjectCount;

                if (currentAve > average)
                {
                    studentHavingHighestAve = pair.Key;
                    average = currentAve;
                }

                
            }
            Console.WriteLine(studentHavingHighestAve);
        }
    }
}
