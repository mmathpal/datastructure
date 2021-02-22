using System;
using System.Collections.Generic;

namespace LogicalConcepts
{
    public class ValidParentheses
    {
        public ValidParentheses()
        {
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else 
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char startingBracket = stack.Pop();


                    if ((s[i] == ']' && startingBracket != '[') || (s[i] == '}' && startingBracket != '{') || (s[i] == ')' && startingBracket != '('))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


    }
}
