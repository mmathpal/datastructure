using System;
namespace LogicalConcepts
{
    //for: "vgjuurrhtkkssshheeepppppasllmnnn" has maximum consecutive repeating char as "p"

    public class MaximumConsecutiveRepeatingChar
    {
        public void MaxConsecutiveRepeatingChar(string word)
        { 
            int previousCount = 0;
            

            char res = char.MaxValue;

            for(int i = 0; i < word.Length - 1; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < word.Length; j++)
                {
                    if(word[i] == word[j])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(currentCount > previousCount)
                {
                    res = word[i];
                    previousCount = currentCount;
                }
            }

            if(res == char.MaxValue)
            {
                throw new Exception("No consecutive repeating character");
            }

            Console.WriteLine("Maximum Consecutive Repeating Char: " + res);

        }

        public void MaxConsecutiveRepeatingCharUsingOneLoop(string word)
        {
            int previousCount = 0;
            int currentCount = 1;
            char res = word[0];

            for(int i = 0; i < word.Length; i++)
            {
                if(i < word.Length - 1 && word[i] == word[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > previousCount)
                    {
                        res = word[i];
                        previousCount = currentCount;
                    }
                    currentCount = 1;
                }
            }

            Console.WriteLine("Maximum Consecutive Repeating Char: " + res);
        }
    }
}
