// Binary Search Implementation

using System;

public class BinarySearchTree
{
    public void Run()
    {
        Console.WriteLine("Binary Search Tree");
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(14);
        bst.Insert(17);
        bst.Insert(3);
        bst.Insert(4);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(8);
        bst.Insert(5);
        Console.WriteLine("Pre Order");
        bst.TraversePreOrder(bst.root);
        Console.WriteLine();
        Console.WriteLine("In Order");
        bst.TraverseInOrder(bst.root);
        Console.WriteLine();
        Console.WriteLine("Post Order");
        bst.TraversePostOrder(bst.root);
        // Console.WriteLine("Result : {0}", IsDataPresent(initialData, valueToBeSearched,0, initialData.Length-1));
    }

    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int intialValue)
        {
            value = intialValue;
            left = right = null;
        }
    }

    public Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public BinarySearchTree(int value)
    {
        root = new Node(value);
    }

    public void Insert(int value)
    {
        Node newNode = new Node(value);
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parent;

            while (true)
            {
                parent = current;
                if (value < current.value)
                {
                    current = current.left;
                    if (parent.left == null)
                    {
                        parent.left = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.right;
                    if (parent.right == null)
                    {
                        parent.right = newNode;
                        break;
                    }
                }

            }
        }
    }

    public void TraversePreOrder(Node parent)
    {
        if (parent != null)
        {
            Console.Write(parent.value+ " ");
            TraversePreOrder(parent.left);
            TraversePreOrder(parent.right);
        }
    }

    public void TraverseInOrder(Node parent)
    {
        if (parent != null)
        {
            TraverseInOrder(parent.left);
            Console.Write(parent.value+ " ");
            TraverseInOrder(parent.right);
        }

    }

    public void TraversePostOrder(Node parent)
    {
        if (parent != null)
        {
            TraversePostOrder(parent.left);
            TraversePostOrder(parent.right);
            Console.Write(parent.value + " ");
        }
    }


}