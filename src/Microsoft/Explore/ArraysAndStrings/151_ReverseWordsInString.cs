//https://leetcode.com/problems/reverse-words-in-a-string/

// Given an input string, reverse the string word by word.



// Example 1:

// Input: "the sky is blue"
// Output: "blue is sky the"
// Example 2:

// Input: "  hello world!  "
// Output: "world! hello"
// Explanation: Your reversed string should not contain leading or trailing spaces.
// Example 3:

// Input: "a good   example"
// Output: "example good a"
// Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

using System;
using System.Text;

public class ReverseString
{
    public void Run()
    {
        string s = "Maximum Length of    Concatenated String";
        Console.WriteLine(ReverseWords(s));
    }

    public string ReverseWords(string s)
    {
        string[] word = s.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
            if (word[i].Trim().Length > 0) sb.Append(word[i].Trim() + " ");
        return sb.ToString().Trim();
    }
}