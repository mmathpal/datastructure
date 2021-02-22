using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalConcepts
{
    public class LongestUniformSubstring
    {
        //Find the longest uniform substring (uniform means that all of the letters in the substring are identical),
        //and return the starting location and the length
        //for: "aabbbkljnnngghedddddccqqq" should return "ddddd"
          
        public void GetLongestUniformSubstring( string word)
        {
            char previous = word[0];
            StringBuilder sb = new StringBuilder();
            sb.Append(previous);
            int index = 0;
            string longestString = string.Empty;

            for(int i = 0; i < word.Length-1; i++)
            {
                if(previous == word[i+1])
                {
                    sb.Append(word[i+1]);
                }
                else
                {
                    sb.Append(previous);
                    if(longestString.Length < sb.ToString().Length)
                    {
                        longestString = sb.ToString();
                        index = i - longestString.Length;
                    }
                    sb = new StringBuilder();
                }
                previous = word[i];
            }


            Console.WriteLine("Lomgest uniform substring:" + longestString);
            Console.WriteLine("Starting Location:" + index);
        }
    }
}
