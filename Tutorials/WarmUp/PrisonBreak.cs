using System;

/*

A prisoner is planning to escape from prison! The prison's gate consists of horizontal and vertical bars
that are spaced one unit apart, so the area of each hole between the bars is 1 × 1. The prisoner manages
to remove certain bars to make some bigger holes. Determine the area of the largest hole in the gate after
the bars are removed.

n = 6
m = 6
h = [4];
v = [2];

In the images below. the left image depicts the initial 
prison gate with n 6 horizontal and m=6 vertical bars. 
The area of the biggest hole in the bars is 1 x 1. The 
right image depicts that same gate after the prisoner 
removes horizontal bar 4 and vertical bar 2, at which 
point the area of the biggest hole in the bars becomes 
2 x2=4  

https://www.chegg.com/homework-help/questions-and-answers/prisoner-planning-escape-prison-prison-s-gate-consists-horizontal-vertical-bars-spaced-one-q54963882

 */

namespace WarmUp
{
    public class PrisonBreak
    {
        public PrisonBreak()
        {
        }

        private static int MaxArea(int n, int m, int[] h, int[] v)
        {

            Array.Sort(h);
            Array.Sort(v);

            int prevHoriLowerBound = Math.Max(0, h[0] - 1);
            int maxHorizonGap = 2;

            for(int i = 1; i < h.Length; i++)
            {
                maxHorizonGap = Math.Max(maxHorizonGap, (h[i] + 1) - prevHoriLowerBound);
                if(h[i] - h[i-1] > 1)
                {
                    prevHoriLowerBound = h[i - 1];
                }
            }

            int prevVeriLowerBound = Math.Max(0, v[0] - 1);
            int maxVerticalGap = 2;

            for (int i = 1; i < v.Length; i++)
            {
                maxVerticalGap = Math.Max(maxVerticalGap, (v[i] + 1) - prevVeriLowerBound);
                if (v[i] - v[i - 1] > 1)
                {
                    prevVeriLowerBound = v[i - 1];
                }
            }

            return maxHorizonGap * maxVerticalGap;
        }


        public static void PerformPrisonBreak()
        {
            int maxArea = MaxArea(3, 2, new int[] { 1, 2, 3}, new int[] { 1, 2 });

            Console.WriteLine(maxArea);
        }
    }    
}
