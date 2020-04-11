// Trie Structure Implementation - Just insert and Search

using System;
using System.Collections.Generic;

public class TrieImplementation
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children;
        public bool endOfWord;

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
            endOfWord = false;
        }
    }

    public TrieNode root;

    public TrieImplementation()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode current = root;
        foreach (char charitem in word)
        {
            TrieNode node = new TrieNode();
            if (!current.children.ContainsKey(charitem))
            {
                current.children.Add(charitem, node);
            }
            else
            {
                node = current.children[charitem];
            }
            current = node;
        }
        current.endOfWord = true;
    }

    public bool Search(string word)
    {
        TrieNode current = root;
        foreach (char letter in word)
        {
            if (current.children.ContainsKey(letter))
            {
                current = current.children[letter];
            }
            else
            {
                return false;
            }            
            continue;
        }
        return current.endOfWord;
    }
}

public class TrieCheck
{
    public void Run()
    {
        TrieImplementation trieStruct = new TrieImplementation();
        trieStruct.Insert("Felix");
        trieStruct.Insert("Anand");
        trieStruct.Insert("Arulraj");
        trieStruct.Insert("Fel");
        Console.WriteLine(trieStruct.Search("Anand"));
    }
}