//https://leetcode.com/problems/intersection-of-two-linked-lists/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

using System;
//using System.Collections.Generic;

public class IntersectionLinkedList
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
        ListNode headC = new ListNode(4);
        ListNode headD = new ListNode(4);
        Console.WriteLine(headC == headD);

        ListNode headA = new ListNode(4);
        headA.next = new ListNode(1);
        headA.next.next = new ListNode(8);
        headA.next.next.next = new ListNode(4);
        headA.next.next.next.next = new ListNode(5);

        ListNode headB = new ListNode(5);
        headB.next = new ListNode(0);
        headB.next.next = new ListNode(1);
        headB.next.next.next = new ListNode(8);
        headB.next.next.next.next = new ListNode(4);
        headB.next.next.next.next.next = new ListNode(5);

        ListNode final = GetIntersectionNode(headA, headB);
        Console.WriteLine(final);

        Console.WriteLine(final == null ? "0" : final.val.ToString());

    }
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        // HashSet<ListNode> cache = new HashSet<ListNode>();

        // ListNode currentNodeA = headA;
        // while (currentNodeA != null)
        // {
        //     cache.Add(currentNodeA);
        //     currentNodeA = currentNodeA.next;
        // }
        // ListNode currentNodeB = headB;
        // while (currentNodeB != null)
        // {
        //     if (cache.Contains(currentNodeB))
        //         return currentNodeB;
        //     else
        //         currentNodeB = currentNodeB.next;
        // }
        // return null;

        if (headA == null || headB == null) return null;

        ListNode a_pointer = headA;
        ListNode b_pointer = headB;

        while (a_pointer != b_pointer)
        {
            if (a_pointer == null)
                a_pointer = headB;
            else
                a_pointer = a_pointer.next;

            if (b_pointer == null)
                b_pointer = headA;
            else
                b_pointer = b_pointer.next;
        }
        return a_pointer;

    }
}