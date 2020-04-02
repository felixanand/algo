// 445. Add Two Numbers II
// https://leetcode.com/problems/add-two-numbers-ii/

// You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Follow up:
// What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

// Example:

// Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 8 -> 0 -> 7

using DSAlgo.Helper.LList;
using System.Collections.Generic;

public class AddTwoNumbers2
{
    public void Run()
    {
        ListNode l1 = new ListNode(7);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(4);
        l1.next.next.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        ListNode finalList = AddTwoNumbers(l1, l2);

        LLHelper.PrintList(finalList);

    }

    private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> stackList1 = AddToStack(l1);
        Stack<int> stackList2 = AddToStack(l2);

        ListNode head = null;
        int carry = 0;

        while (stackList1.Count > 0 || stackList2.Count > 0 || carry > 0)
        {
            int val1 = stackList1.Count > 0 ? stackList1.Pop() : 0;
            int val2 = stackList2.Count > 0 ? stackList2.Pop() : 0;
            int val = val1 + val2 + carry;
            carry = val / 10;
            val = val % 10;
            ListNode node = new ListNode(val);
            node.next = head;
            head = node;
        }

        return head == null ? new ListNode(0) : head;
    }

    private Stack<int> AddToStack(ListNode ll)
    {
        Stack<int> stackData = new Stack<int>();
        while (ll != null)
        {
            stackData.Push(ll.val);
            ll = ll.next;
        }
        return stackData;
    }
}