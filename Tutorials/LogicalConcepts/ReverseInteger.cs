using System;
namespace LogicalConcepts
{
    public class ReverseInteger
    {
        public ReverseInteger()
        {
        }

        public int Reverse(int x)
        {

            string word = x.ToString();

            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                word = word.Substring(1);
            }

            int left = 0;
            int right = word.Length - 1;
            Console.WriteLine(word);
            char[] str = word.ToCharArray();
            while (left < right)
            {
                var temp = str[left];
                str[left] = word[right];
                str[right] = temp;

                left++;
                right--;
            }

            word = string.Join("", str);
            try
            {
                x = Convert.ToInt32(word);
            }
            catch
            {
                return 0;
            }
            
            if (isNegative)
            {
                x = -x;
            }

            return x;
        }
    }
}
