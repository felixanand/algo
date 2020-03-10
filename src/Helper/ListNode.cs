namespace DSAlgo.Helper.LList
{
    using System;
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode prev { get; set; }
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public static class LLHelper
    {
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + "->");
                node = node.next;
            }
            Console.Write("null");
            Console.WriteLine("\n");
        }

    }
}