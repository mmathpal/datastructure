using System;
namespace LogicalConcepts
{
    public class SecondSmallestInArray
    {
        public int SecondSmallestNumber(int[] args)
        {
            if(args.Length < 2)
            {
                throw new InvalidOperationException("array must have atleast two values.");
            }
            int firstSmallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            for(int i = 0; i < args.Length; i++)
            {
                if(firstSmallest > args[i])
                {
                    secondSmallest = firstSmallest;
                    firstSmallest = args[i];
                }

                if(secondSmallest > args[i] && args[i] != firstSmallest)
                {
                    secondSmallest = args[i];
                }
            }

            return secondSmallest;
        }
    }
}
