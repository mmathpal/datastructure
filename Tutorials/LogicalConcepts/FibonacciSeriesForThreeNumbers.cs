using System;
using System.Collections.Generic;

namespace LogicalConcepts
{
    public class FibonacciSeriesForThreeNumbers
    {
        public void GenerateSeries(int numberOfItems)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 1;

            var lstSeries = new List<int>() { firstNumber, secondNumber, thirdNumber };

            while(true)
            {
                if(lstSeries.Count >= numberOfItems)
                {
                    break;
                }

                int result = firstNumber + secondNumber + thirdNumber;
                lstSeries.Add(result);

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = result;
            }

            foreach (var item in lstSeries)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
