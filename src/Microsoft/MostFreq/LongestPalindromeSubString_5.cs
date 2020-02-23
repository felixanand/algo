//https://leetcode.com/problems/longest-palindromic-substring/

using System;
using System.Collections.Generic;

// WIP

public class LongestPalindromeSubstring_5
{
    public void Run()
    {
        string str = "babad";
        string longestString = LongestPalindrome(str);
        Console.Write(longestString);
    }

    private string LongestPalindrome(string s)
    {
        if (s == null || s.Length < 1) return "";
        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = maxLengthExpandFormula(s, i, i);
            int len2 = maxLengthExpandFormula(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i - ((len - 1) / 2);
                end = i + (len / 2);
            }
        }
        return s.Substring(start, end + 1);
    }

    private int maxLengthExpandFormula(string s, int left, int right)
    {
        if (s == null || left > right) return 0;

        while (left >= 0 && right < s.Length  && s[left] == s[right])
        {
            // Expand
            left--;
            right++;
        }
        // send where the merge start
        return right - left - 1;
    }

}