using System.Xml.Linq;
// https://leetcode.com/problems/longest-valid-parentheses/
// 32. Longest Valid Parentheses

// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.

// Example 1:

// Input: "(()"
// Output: 2
// Explanation: The longest valid parentheses substring is "()"
// Example 2:

// Input: ")()())"
// Output: 4
// Explanation: The longest valid parentheses substring is "()()"

using System;
using System.Collections.Generic;

public class LongestValidParan
{
    public void Run()
    {
        string input = "()(()";
        int output = LongestValidParentheses(input);
        Console.WriteLine(output);
    }

    private int LongestValidParentheses(string s)
    {
        if (s.Length == 0) return 0;
        int count = 0;
        Stack<char> store = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                store.Push(s[i]);
            }
            else if (s[i] == ')' && store.Count == 0)
            {
                continue;
            }
            else
            {
                if (store.Count > 0 && store.Peek() == '(')
                {
                    store.Pop();
                    count = count + 2;
                }
            }
        }
        return count;
    }
}