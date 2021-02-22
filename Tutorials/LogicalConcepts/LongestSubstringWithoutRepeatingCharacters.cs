using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalConcepts
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public LongestSubstringWithoutRepeatingCharacters()
        {
        }

        public static int FindNonRepeatingLongestSubstring(string s)
        {
            int n = s.Length;

            // Result  
            int res = 0;

            for (int i = 0; i < n; i++)
            {

                // Note : Default values in visited are false  
                bool[] visited = new bool[256];

                for (int j = i; j < n; j++)
                {

                    // If current character is visited  
                    // Break the loop  
                    if (visited[s[j]] == true)
                        break;

                    // Else update the result if  
                    // this window is larger, and mark  
                    // current character as visited.  
                    else
                    {
                        res = Math.Max(res, j - i + 1);
                        visited[s[j]] = true;
                    }
                }

                // Remove the first character of previous  
                // window  
                visited[s[i]] = false;
            }
            return res;

        }

    }
}
