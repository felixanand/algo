using System;

public class LinkedListSingleImpl
{
    public static void Run()
    {
        SingleLinkedList node = new SingleLinkedList(1);
        SingleLinkedList node1 = node.AddNext(5);
        SingleLinkedList node2 = node1.AddNext(4);
        SingleLinkedList node3 = node2.AddNext(3);
        node2.RemoveLast();
        node.TraverseList(null);
    }
}

class SingleLinkedList
{
    public int val;
    public SingleLinkedList next;
    public SingleLinkedList()
    {
        val = 0;
        next = null;
    }
    public SingleLinkedList(int x)
    {
        val = x;
        next = null;
    }

    public SingleLinkedList AddNext(int x)
    {
        SingleLinkedList node = new SingleLinkedList(x);
        if (this.next == null)
        {
            this.next = node;
            node.next = null;
        }
        else
        {
            SingleLinkedList temp = this.next;
            this.next = node;
            node.next = temp;
        }
        return node;
    }

    public int RemoveLast()
    {
        if (next == null)
        {
            return 0;
        }
        SingleLinkedList node = this.next;
        this.next = this.next.next;
        node = null;
        return 1;
    }

    public void TraverseList(SingleLinkedList node)
    {
        if (node == null) node = this;
        while (node != null)
        {
            Console.Write(node.val + "->");
            node = node.next;
        }
    }

}