//https://leetcode.com/problems/add-two-numbers/

// Share
// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order 
//and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Example:

// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8
// Explanation: 342 + 465 = 807.

using System;

public class Add2NumberLinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public void Run()
    {
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        ListNode l3 = AddTwoNumbers(l1, l2);
        PrintListNode(l3);
    }

    private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null)
            return null;
        if (l1 == null)
            l1 = new ListNode(0);
        if (l2 == null)
            l2 = new ListNode(0);
        int sum = l1.val + l2.val;
        ListNode result = new ListNode(sum % 10);
        if (sum >= 10)
            result.next = AddTwoNumbers(AddTwoNumbers(l1.next, l2.next), new ListNode(1));
        else
            result.next = AddTwoNumbers(l1.next, l2.next);
        return result;
    }

    private void PrintListNode(ListNode l)
    {
        if (l == null) return;
        while (l != null)
        {
            Console.Write(l.val + "->");
            l = l.next;
        }
        Console.Write("null");
    }
}