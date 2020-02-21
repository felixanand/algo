using System;

public class ReverseLinkedList
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
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        ListNode currentNode = head;
        PrintList(currentNode);

        ListNode result = ReverseList(head);
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

    public ListNode ReverseList(ListNode head)
    {
        ListNode currentNode = head;
        ListNode previousNode = null;
        ListNode temp;

        while (currentNode != null)
        {
            temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        return previousNode;

    }


};