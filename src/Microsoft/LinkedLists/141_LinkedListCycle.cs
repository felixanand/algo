//https://leetcode.com/problems/linked-list-cycle/

// Given a linked list, determine if it has a cycle in it.

// To represent a cycle in the given linked list, we use an integer pos which represents 
// the position (0-indexed) in the linked 
// list where tail connects to. If pos is -1, then there is no cycle in the linked list.

using System;
public class LinkedListCycle_141
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public void Run()
    {

        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-1);
        //head.next.next.next.next = head.next;

        bool isCyclic = HasCycle(head);
        Console.WriteLine(isCyclic);
    }

    private bool HasCycle(ListNode head)
    {
        // Planning to solve using Floyd's algorithm
        ListNode slow = head;
        ListNode fast = head;

        while (slow != null && fast != null)
        {
            // If no next element, no cycles exsist
            if (slow.next == null || fast.next == null)
            return false;

            slow = slow.next;
            fast = fast.next.next;
            
            // If both nodes meet, then there is a cycle
            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}