// https://leetcode.com/problems/merge-two-sorted-lists/

// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

// Example:

// Input: 1->2->4, 1->3->4
// Output: 1->1->2->3->4->4

using System;

public class Merge2SortedLists
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
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(4);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode result = MergeTwoLists(l1, l2);
        PrintList(result);

    }

    private void PrintList(ListNode currentNode)
    {
        while (currentNode != null)
        {
            Console.Write(currentNode.val + " -> ");
            currentNode = currentNode.next;
        }
        Console.Write("null");
        Console.WriteLine("\n");
    }

    private ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode tempNode = new ListNode(0);
        ListNode currentNode = tempNode;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                currentNode.next = l1;
                l1 = l1.next;
            }
            else
            {
                currentNode.next = l2;
                l2 = l2.next;
            }
            currentNode = currentNode.next;
        }

        if (l1 != null)
        {
            currentNode.next = l1;
            l1 = l1.next;
        }

        if (l2 != null)
        {
            currentNode.next = l2;
            l2 = l2.next;
        }

        return tempNode.next;

    }
}

