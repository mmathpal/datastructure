using System;
namespace LogicalConcepts
{
    public class Palindrome
    {

        public bool CheckIfPalindrome(string word)
        {
            int leftIndex = 0;
            int rightIndex = word.Length;
            while(true)
            {
                if(leftIndex == rightIndex)
                {
                    return true;
                }

                char a = word[leftIndex];
                char b = word[rightIndex];

                if(char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                leftIndex++;
                rightIndex--;
            }
            
        }
    }
}
