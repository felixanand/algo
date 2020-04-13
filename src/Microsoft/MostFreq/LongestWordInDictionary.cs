// https://leetcode.com/problems/longest-word-in-dictionary/
// 720. Longest Word in Dictionary

// Given a list of strings words representing an English Dictionary, find the longest word in words that can be built one character at a time by other words in words. If there is more than one possible answer, return the longest word with the smallest lexicographical order.

// If there is no answer, return the empty string.
// Example 1:
// Input: 
// words = ["w","wo","wor","worl", "world"]
// Output: "world"
// Explanation: 
// The word "world" can be built one character at a time by "w", "wo", "wor", and "worl".
// Example 2:
// Input: 
// words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
// Output: "apple"
// Explanation: 
// Both "apply" and "apple" can be built from other words in the dictionary. However, "apple" is lexicographically smaller than "apply".

using System;
using System.Collections.Generic;
using System.Linq;

public class LongestWordInDictionary
{
    public void Run()
    {
        string[] input = {"a","banana","app","appl","ap","apply","apple","applyt"};
        //string[] input = {"w","wo","wor","worl", "world"};
        string output = LongestWord(input);
        Console.WriteLine(output);
    }

    public string LongestWord(string[] input)
    {
        if (input.Length == 1) return input[0];
        
        string longestWord = "";
        Array.Sort(input);
        HashSet<string> dataInSet = new HashSet<string>();

        for(int i=0; i<= input.Length - 1;i++)
        {
            if(input[i].Length == 1 || dataInSet.Contains(input[i].Substring(0,input[i].Length-1)))
            {
                dataInSet.Add(input[i]);
                if (input[i].Length > longestWord.Length) longestWord = input[i];
            }
        }

        return longestWord;
    }
}