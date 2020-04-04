using System;

public class LinkedListCircularImpl
{
    public static void Run()
    {
        CircularLinkedList node = new CircularLinkedList(1);
        CircularLinkedList node1 = node.AddNext(5);
        CircularLinkedList node2 = node1.AddNext(4);
        CircularLinkedList node3 = node2.AddNext(3);
        node2.RemoveLast();        
        node.ConvertToCircular(node);
        node.TraverseList(node);
    }
}

class CircularLinkedList
{
    public int val;
    public CircularLinkedList next;
    public CircularLinkedList()
    {
        val = 0;
        next = null;
    }
    public CircularLinkedList(int x)
    {
        val = x;
        next = null;
    }

    public CircularLinkedList AddNext(int x)
    {
        CircularLinkedList node = new CircularLinkedList(x);
        if (this.next == null)
        {
            this.next = node;
            node.next = null;
        }
        else
        {
            CircularLinkedList temp = this.next;
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
        CircularLinkedList node = this.next;
        this.next = this.next.next;
        node = null;
        return 1;
    }

    public void ConvertToCircular(CircularLinkedList node)
    {
        CircularLinkedList headNode = node; 
        while(node.next!=null)
        {
            node=node.next;
        }
        node.next = headNode;
    }

    public void TraverseList(CircularLinkedList node)
    {
        if (node == null) node = this;
        while (node != null)
        {
            Console.Write(node.val + "->");
            node = node.next;
        }
    }

}