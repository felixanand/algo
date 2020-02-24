//https://leetcode.com/problems/validate-binary-search-tree/

using System;
public class ValidBST
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
        TreeNode root = new TreeNode(2);
        root.left = new TreeNode(1);
        root.right = new TreeNode(3);
        Console.WriteLine(IsValidBST(root));
    }

    private bool IsValidBST(TreeNode root, int? max = null, int? min = null)
    {
        if (root == null)
            return true;

        if ((max != null && root.val >= max) || (min != null && root.val <= min))
            return false;

        return IsValidBST(root.left, root.val, min) && IsValidBST(root.right, max, root.val);
    }
}