// https://leetcode.com/problems/binary-tree-inorder-traversal/

using System;
using System.Collections.Generic;
using System.Linq;
public class BinaryTreeLevelOrderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }

    public void Run()
    {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);
        IList<IList<int>> result = LevelOrder(root);
        foreach (IList<int> item in result)
        {
            foreach (int element in item)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        Queue<TreeNode> queueHolder = new Queue<TreeNode>();
        queueHolder.Enqueue(root);

        while (queueHolder.Any())
        {
            var size = queueHolder.Count;
            List<int> level = new List<int>();

            for (int i = 0; i < size; i++)
            {
                var curr = queueHolder.Dequeue();
                level.Add(curr.val);
                
                if (curr.left != null) queueHolder.Enqueue(curr.left);
                if (curr.right != null) queueHolder.Enqueue(curr.right);

            }
            result.Add(level);
        }

        return result;

    }

}
