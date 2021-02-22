using System;
using System.Collections.Generic;

namespace LogicalConcepts
{
    public class FibonacciSeries
    {
        public void GenerateFibonacciSeries(int numberOfItems)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            List<int> series = new List<int>();

            series.Add(firstNumber);
            series.Add(secondNumber);

            while (true)
            {
                if(series.Count >= numberOfItems)
                {
                    break;
                }

                int result = firstNumber + secondNumber;
                series.Add(result);

                firstNumber = secondNumber;
                secondNumber = result;
            }

            foreach(var item in series)
            {
                Console.Write(item + ", ");
            }
        }

        public void GenerateFibonacciSeries1(int numberOfItems)
        {
            int a = 0;
            int b = 0;
            int c;

            while(numberOfItems > 0)
            {
                Console.WriteLine(a);

                c = a + b;
                a = b;
                b = c;

                numberOfItems--;
            }
        }

            public int GenerateFibonacciSeriesUsingRecursion(int n)
        {
            if (n == 0)
                return 0;

            else if (n == 1) return 1;
            else
            {
                int ret = GenerateFibonacciSeriesUsingRecursion(n - 1) + GenerateFibonacciSeriesUsingRecursion(n - 2);

                return ret;
            }
        }
    } 

}
