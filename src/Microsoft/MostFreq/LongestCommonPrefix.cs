// https://leetcode.com/problems/longest-common-prefix/
// 14. Longest Common Prefix

// Write a function to find the longest common prefix string amongst an array of strings.

// If there is no common prefix, return an empty string "".

// Example 1:

// Input: ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.

using System;
using System.Linq;

public class LongestCommonPrefixSoln
{
    public void Run()
    {
        string[] input = { "flower", "flow", "flight" };
        string output = LongestCommonPrefix(input);
        Console.WriteLine(output);
    }

    string LongestCommonPrefix(string[] input)
    {
        if (input.Length == 0) return string.Empty;
        if (input.Length == 1) return input[0];

        String prefix = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            while (input[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}