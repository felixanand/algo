//https://leetcode.com/problems/valid-parentheses/

using System;
using System.Collections.Generic;
public class ValidParanthesis_20
{
    public void Run()
    {
        string str = "([)]";
        bool isValidParen = IsValid(str);
        Console.Write(isValidParen);
    }

    private bool IsValid(string s)
    {
        if (String.IsNullOrEmpty(s)) return true;

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
            }
            else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
            {
                if (stack.Count == 0) return false;

                char previous = stack.Pop();
                if ((previous == '{' && s[i] == '}') ||
                    (previous == '[' && s[i] == ']') ||
                    (previous == '(' && s[i] == ')'))
                {
                    continue;
                }
                else
                    return false;
            }
        }
        return stack.Count==0;
    }
}