// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// 3. Longest Substring Without Repeating Characters

// Given a string, find the length of the longest substring without repeating characters.

// Example 1:

// Input: "abcabcbb"
// Output: 3 
// Explanation: The answer is "abc", with the length of 3. 
// Example 2:

// Input: "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3. 
//              Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

using System;
using System.Collections.Generic;

// Let's using Slinding window technique

public class MaxLengthOfNonRCChar
{
    public void Run()
    {
        string testData = "cabcda";
        int maxLength = LengthOfLongestSubstring(testData);
        Console.WriteLine(maxLength);
    }

    int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int leftIndex = 0;
        int rightIndex = 0;

        HashSet<char> set = new HashSet<char>();
        // Window sliding 2 pointer technique
        
        while (rightIndex < s.Length)
        {
            var current = s[rightIndex];

            if (!set.Contains(s[rightIndex]))
            {
                set.Add(current);
                rightIndex++;
                maxLength = Math.Max(maxLength, set.Count);
            }
            else
            {
                set.Remove(s[leftIndex]);
                leftIndex++;
            }
        }
        return maxLength;

    }

}
