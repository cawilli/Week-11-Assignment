using System;

namespace LeetcodeSinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Line 1: Char 7: warning CS0105: The using directive for 'System' appeared previously in this namespace (in Solution.cs) Line 15: Char 84: error CS0246: The type or namespace name 'MyLinkedList' could not be found (are you missing a using directive or an assembly reference?) (in __Driver__.cs) Line 42: Char 20: error CS0246: The type or namespace name 'MyLinkedList' could not be found (are you missing a using directive or an assembly reference?) (in __Driver__.cs)
    public class Node
    {
        public int val;
        public Node first;
        public Node next;       

    }    
    public class LinkedList
    {
        
        Node head;
        Node tail;
        int length = 0;
        public int myLinkedListGet(int index)
        {
            int first = 0;
            Node current = head;            
            while( first != index && current != null)
            {
                current = current.next;
                first++;
            }
            return -1;
        }         
        public void myLinkedListAddAtHead(int val)
        {
            Node head = new Node();
            head.next = head;
            length++;            
        }
        public void myLinkedListAddAtTail(int val)
        {
            Node tail = new Node();
            tail.next = tail;
            length++;
        }
        public void myLinkedListAddAtIndex(int index, int val)
        {
            if (index !<= length)
            {
                return;
            }          
            if (index == 0)
            {
                myLinkedListAddAtHead(val);
            }
            else
            {
                myLinkedListAddAtTail(val);
            }
            return;                
        }
        public void myLinkedListDeleteAtIndex(int index)
        {
            Node temp = head;
            if (index == 0)
            {
                if (temp != null)
                {                   
                    head = temp.next;
                }
            }
        }
    }
    
}
