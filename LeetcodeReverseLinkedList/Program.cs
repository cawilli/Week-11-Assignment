using System;

namespace LeetcodeReverseLinkedList
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
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next;

            while (curr != null)
            {
                // You want to change curr.next to equal the previous item, not the next item. 
                // 1. Store curr.next
                var temp = curr.next;
                // 2. Change curr.next to point to the previous value
                curr.next = prev;
                // 3. Ready the loop for the next pass by updating prev
                prev = curr;
                // 4. Ready the loop for the next pass by updating curr.
                curr = temp;
            }

            return prev;
        }


    }
}
