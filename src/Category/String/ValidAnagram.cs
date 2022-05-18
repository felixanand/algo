// 242. https://leetcode.com/problems/valid-anagram/submissions/

/* Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true */

using System;
using System.Linq;

public class ValidAnagram
{
    public void Run()
    {
        var s1 = "rat";
        var s2 = "tbr";
        Console.WriteLine(IsValidAnagram(s1, s2));
    }

    private bool IsValidAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;

        var s1Arr = s1.ToCharArray();
        Array.Sort(s1Arr);
        var s2Arr = s2.ToCharArray();
        Array.Sort(s2Arr);

        if (s1Arr.SequenceEqual(s2Arr)) return true;

        return false;

    }

}


