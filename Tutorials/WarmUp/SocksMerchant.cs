using System;
using System.Collections.Generic;
using System.Linq;

/*

There is a large pile of socks that must be paired by color. Given an array of integers representing the color of
each sock, determine how many pairs of socks with matching colors there are.

 * */

namespace WarmUp
{
    public class SocksMerchant
    {
        internal static int GetSockPairs(int n, int[] ar)
        {
            var lstSocks = new HashSet<int>();

            int sockPairCounter = 0;
            for(int i=0; i<n; i++)
            {
                if(!lstSocks.Contains(ar[i]))
                {
                    lstSocks.Add(ar[i]);
                }
                else
                {
                    sockPairCounter++;
                    lstSocks.Remove(ar[i]);
                }
            }

            return sockPairCounter;

        }
    }
}