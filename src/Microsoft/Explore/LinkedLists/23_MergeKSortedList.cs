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

using System.Collections.Generic;
using DSAlgo.Helper.LList;
using System.Linq;

public class MergeKSortedListLL
{
    public void Run()
    {
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(5);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode l3 = new ListNode(2);
        l3.next = new ListNode(6);

        ListNode[] input = new ListNode[] { l1, l2, l3 };

        ListNode finalList = MergeKLists(input);
        //LLHelper.PrintList(finalList);

    }

    public class MinHeap
    {
        public SortedDictionary<int, Queue<ListNode>> map = new SortedDictionary<int, Queue<ListNode>>();

        public void Add(int val, ListNode node)
        {
            if(!map.ContainsKey(val))
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
            if(node == null)
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