
// 22. Generate Parentheses
// https://leetcode.com/problems/generate-parentheses

// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

// For example, given n = 3, a solution set is:

// [
//   "((()))",
//   "(()())",
//   "(())()",
//   "()(())",
//   "()()()"
// ]

using System;
using System.Collections.Generic;

public class ParenthesisCreate
{
    public void Run()
    {
        int number = 3;
        IList<string> output = GenerateParenthesis(number);
        foreach (string item in output)
        {
            Console.WriteLine(item);
        }
    }

    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> output = new List<string>();
        backtrack(output, "", 0, 0, n);
        return output;
    }

    private void backtrack(IList<string> output, string currentString, int openCount, int closeCount, int max)
    {
        if (currentString.Length == max * 2)
        {
            output.Add(currentString);
            return;
        }

        if (openCount < max) backtrack(output, currentString + '(', openCount + 1, closeCount, max);
        if (closeCount < openCount) backtrack(output, currentString + ')', openCount, closeCount + 1, max);
    }
}
