// https://leetcode.com/problems/binary-tree-inorder-traversal/

using System;
using System.Collections.Generic;
public class BinaryTreeInOrderTraversal
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
        TreeNode root = new TreeNode(1);
        root.right = new TreeNode(2);
        root.right.left = new TreeNode(3);
        IList<int> result = InorderTraversal(root);
        foreach (int item in result) Console.WriteLine(item);
    }

    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> retVal = new List<int>();
        InorderTraversal(root, ref retVal);
        return retVal;
    }

    private void InorderTraversal(TreeNode root, ref IList<int> retVal)
    {
        if(root!=null)
        {
            InorderTraversal(root.left, ref retVal);
            retVal.Add(root.val);
            InorderTraversal(root.right, ref retVal);            
        }
    }
}
