using System;
using System.Collections.Generic;

namespace LogicalConcepts
{
    public class FirstNonRepeatingCharInString
    {
        public char GetFirstNonRepeatingCharUsingList(string word)
        {
            if(word.Length < 2)
            {
                return word[0];
            }

            List<char> hs = new List<char>();

            for(int i = 0; i < word.Length; i++)
            {
                if(!hs.Contains(word[i]))
                {
                    hs.Add(word[i]);
                }
                else
                {
                    hs.Remove(word[i]);
                }
            }

            return hs[0];
        }

    }
}
