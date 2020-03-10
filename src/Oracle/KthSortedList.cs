// 23. Merge k Sorted Lists
// https://leetcode.com/problems/merge-k-sorted-lists/

// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.

// Example:

// Input:
// [
//   1->4->5,
//   1->3->4,
//   2->6
// ]
// Output: 1->1->2->3->4->4->5->6

using DSAlgo.Helper.LList;
using System;
using System.Collections.Generic;
using System.Linq;

public class KthSortedList
{
    public void Run()
    {
        ListNode[] inputListNode = new ListNode[3];
        ListNode node1 = new ListNode(1);
        node1.next = new ListNode(4);
        node1.next.next = new ListNode(5);
        ListNode node2 = new ListNode(1);
        node2.next = new ListNode(3);
        node2.next.next = new ListNode(4);
        ListNode node3 = new ListNode(2);
        node3.next = new ListNode(6);
        inputListNode[0] = node1;
        inputListNode[1] = node2;
        inputListNode[2] = node3;
        ListNode finalData = MergeKLists(inputListNode);
        LLHelper.PrintList(finalData);

    }

    public class MinHeap
    {
        public SortedDictionary<int, Queue<ListNode>> map = new SortedDictionary<int, Queue<ListNode>>();

        public void Add(int val, ListNode node)
        {
            if (!map.ContainsKey(val))
            {
                map.Add(val, new Queue<ListNode>());
            }

            map[val].Enqueue(node);
        }

        public ListNode PopMin()
        {
            int minKey = map.First().Key;
            ListNode node = map[minKey].Dequeue();

            if (map[minKey].Count == 0)
                map.Remove(minKey);

            return node;
        }
    }

    public ListNode MergeKLists(ListNode[] lists)
    {
        MinHeap heap = new MinHeap();
        foreach (var node in lists)
        {
            if (node == null)
                continue;

            heap.Add(node.val, node);
        }

        ListNode curr = null, newHead = null;

        while (heap.map.Count > 0)
        {
            ListNode node = heap.PopMin();

            if (node.next != null)
            {
                heap.Add(node.next.val, node.next);
            }

            if (curr == null)
            {
                curr = node;
                newHead = curr;
            }
            else
            {
                curr.next = node;
                curr = curr.next;
            }
        }

        return newHead;
    }
}