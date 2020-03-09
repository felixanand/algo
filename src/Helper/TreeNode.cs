
namespace DSAlgo.Helper.Tree
{
    using System;

    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int x)
        {
            val = x;
        }
    }

    public static class TraversalHelper
    {
        public static void TraversePreOrder(TreeNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.val + " ");
                TraversePreOrder(parent.left);
                TraversePreOrder(parent.right);
            }
        }

        public static void TraverseInOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.left);
                Console.Write(parent.val + " ");
                TraverseInOrder(parent.right);
            }

        }

        public static void TraversePostOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.left);
                TraversePostOrder(parent.right);
                Console.Write(parent.val + " ");
            }
        }

    }
}