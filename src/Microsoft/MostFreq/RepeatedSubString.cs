using System.Net.Mime;
// https://leetcode.com/problems/repeated-substring-pattern/
// 459. Repeated Substring Pattern

// Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

// TBDx

// Example 1:

// Input: "abab"
// Output: True
// Explanation: It's the substring "ab" twice.
// Example 2:

// Input: "aba"
// Output: False
// Example 3:

// Input: "abcabcabcabc"
// Output: True
// Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)

using System;
using System.Linq;

public class RepeatedSubString
{
    public void Run()
    {
        string input = "abcabcabcabc";
        Console.WriteLine(RepeatedSubstringPattern(input));
    }

    private Boolean RepeatedSubstringPattern(string s)
    {
        int strLength = s.Length;
        if (strLength < 0) return false;
        if (strLength == 1) return true;

        int end = s.Length - 1;
        bool foundAtleastOne = false;

        for (int i = 1; i <= s.Length - 1; i++)
        {
            if (s[0] == s[i])
            {
                foundAtleastOne = true;
                end = i;
                break;
            }
        }

        // string wordToBeSearched = s.Substring(0, end);
        // string[] words = from word in s  
        //                  where word.Equals(wordToBeSearched.ToLowerInvariant())  
        //                  select word; 

        // if (count * (wordToBeSearched.Length) == s.Length)
        // {
        //     return true;
        // }

        return foundAtleastOne;
    }
}