// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
// 230. Kth Smallest Element in a BST

// Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

// Note:
// You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

// Example 1:

// Input: root = [3,1,4,null,2], k = 1
//    3
//   / \
//  1   4
//   \
//    2
// Output: 1

using System;
using System.Collections.Generic;

public class KthSmallestBST
{
    // Tried in order traversal - recursive method

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
        TreeNode node = new TreeNode(3);
        node.left = new TreeNode(1);
        node.right = new TreeNode(4);
        node.left.right = new TreeNode(2);
        int k = 1;
        int result = KthSmallest(node, k);
        Console.WriteLine(result);
    }

    public int KthSmallest(TreeNode root, int k)
    {
        List<int> sortedList = OrderedList(root);
        return sortedList[k - 1];
    }

    private List<int> OrderedList(TreeNode root)
    {

        if(root == null)
            return new List<int>();
        
        List<int> result = new List<int>();
        
        // FOr Kth largest use right, val and left
        if (root.left != null) result.AddRange(OrderedList(root.left));
        result.Add(root.val);
        if (root.right != null) result.AddRange(OrderedList(root.right));

        return result;
    }

}