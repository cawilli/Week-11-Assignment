using System;

namespace LeetcodeAddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers (ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode head = null;
            ListNode tail = head;
            while (l1 != null || l2 != null)
            {
                if (head == null)
                {
                    tail = head = new ListNode(total);
                }
                else
                {
                    tail = tail.next = new ListNode(total);
                }
            }           
            
        }
    }
}
