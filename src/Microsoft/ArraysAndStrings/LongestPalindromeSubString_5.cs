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
        if (string.IsNullOrEmpty(s)) return "";

        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            // Odd palindromes
            longest = ExpandPalindrome(s, i, i, longest);
            // Even palindromes
            longest = ExpandPalindrome(s, i, i + 1, longest);
        }
        return longest;
    }

    private static string ExpandPalindrome(string str, int left, int right, string longestPalindrome)
    {
        int maxLength = longestPalindrome.Length;
        string longest = longestPalindrome;

        while (left >= 0 && right < str.Length && str[left] == str[right])
        {
            int rest = right - left + 1;
            string subString = str.Substring(left, rest);
            int subStringLength = subString.Length;

            if (subStringLength > maxLength)
            {
                maxLength = subStringLength;
                longest = subString;
            }

            left--;
            right++;
        }

        return longest;
    }

}