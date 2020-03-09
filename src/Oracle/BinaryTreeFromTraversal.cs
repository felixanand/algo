// LeetCode 105. Construct Binary Tree from Preorder and Inorder Traversal
// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

// I hope this helps those folks who can't figure out how to get the index of the right child:

// Our aim is to find out the index of right child for current node in the preorder array
// We know the index of current node in the preorder array - preStart (or whatever your call it), it's the root of a subtree
// Remember pre order traversal always visit all the node on left branch before going to the right ( root -> left -> ... -> right), therefore, we can get the immediate right child index by skipping all the node on the left branches/subtrees of current node
// The inorder array has this information exactly. Remember when we found the root in "inorder" array we immediately know how many nodes are on the left subtree and how many are on the right subtree
// Therefore the immediate right child index is preStart + numsOnLeft + 1 (remember in preorder traversal array root is always ahead of children nodes but you don't know which one is the left child which one is the right, and this is why we need inorder array)
// numsOnLeft = root - inStart.

using DSAlgo.Helper.Tree;

public class BinaryTreeFromTraversal
{
    public void Run()
    {
        int[] preOrder = { 3, 9, 20, 15, 7 };
        int[] inOrder = { 9, 3, 15, 20, 7 };
        TreeNode finalData = BuildTree(preOrder, inOrder);

        TraversalHelper.TraverseInOrder(finalData);
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return Helper(0, 0, inorder.Length - 1, preorder, inorder);
    }

    private TreeNode Helper(int preStartIndex, int inStartIndex, int inEndIndex, int[] preOrder, int[] inOrder)
    {
        if (preStartIndex > preOrder.Length - 1 || inStartIndex > inEndIndex) return null;

        TreeNode root = new TreeNode(preOrder[preStartIndex]);

        int inIndex = 0;
        for (int i = inStartIndex; i <= inEndIndex; i++)
        {
            if (root.val == inOrder[i])
            {
                inIndex = i;
            }
        }

        root.left = Helper(preStartIndex + 1, inStartIndex, inIndex - 1, preOrder, inOrder);
        root.right = Helper(preStartIndex + inIndex - inStartIndex + 1, inIndex + 1, inEndIndex, preOrder, inOrder);

        return root;
    }

}

