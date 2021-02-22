using System;
using System.Text;

namespace LogicalConcepts
{
    public class Test
    {
        public Test()
        {

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            string s1 = "";
            string s2 = "";

            while (l1.next != null)
            {
                s1 = s1 + l1.val.ToString();
            }

            while (l2.next != null)
            {
                s2 = s2 + l2.val.ToString();
            }


            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Reverse(c1);
            Array.Reverse(c2);

            int firstNum = int.Parse(string.Join("", c1));
            int secondNum = int.Parse(string.Join("",c2));

            char[] c3 = (firstNum + secondNum).ToString().ToCharArray();

            Array.Reverse(c3);

            ListNode node = new ListNode();

            for (int i = 0; i < c3.Length; i++)
            {
                node.val = int.Parse(c3[i].ToString());
                node.next = new ListNode();
            }

            return node;

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
         }
    }
}
