using System;
namespace LogicalConcepts
{
    public class ReverseString
    {
        public void GetReverseString(string word)
        {
            char[] str = word.ToCharArray();

            int lhs = 0;
            int rhs = word.Length - 1;

            while(true)
            {
                if(lhs >= rhs)
                {
                    break;
                }

                char temp = str[lhs];
                str[lhs] = str[rhs];
                str[rhs] = temp;

                lhs++;
                rhs--;
            }

            Console.WriteLine("Original String: " + word);
            Console.WriteLine("Reverse String is: " + string.Join("",str));
        }
    }
}
