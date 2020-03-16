//https://leetcode.com/problems/reverse-words-in-a-string-ii/

// Given an input string , reverse the string word by word. 

// Example:

// Input:  ['t','h','e',' ','s','k','y',' ','i','s',' ','b','l','u','e']
// Output: ['b','l','u','e',' ','i','s',' ','s','k','y',' ','t','h','e']

// Note: 

// A word is defined as a sequence of non-space characters.
// The input string does not contain leading or trailing spaces.
// The words are always separated by a single space.
// Follow up: Could you do it in-place without allocating extra space?

using System;
public class ReverseString2_186
{
    public void Run()
    {
        char[] s = new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
        ReverseWords(s);
        foreach (char t in s)
        {
            Console.WriteLine(s);
        }
    }

    private void ReverseWords(char[] str)
    {
        int start = 0, end = str.Length - 1;
        //Reverse the entire string.
        Reverse(str, start, end);

        start = 0;
        // Reverse every single letter
        for (int i = 0; i < str.Length; i++) 
        {
            if (str[i] == ' ' || i == str.Length - 1)
            {
                // First loop, start is 0 and end is the previous character before space
                if (i == str.Length - 1)
                    end = i; // For the last character there is no space afterwords
                else end = i - 1;
                // Now reverse the individual word
                Reverse(str, start, end);
                // Now set the start to character after space
                start = i + 1;
            }
        }
    }

    private void Reverse(char[] str, int start, int end)
    {
        while (start < end)
        {
            char t = str[start];
            str[start++] = str[end];
            str[end--] = t;
        }
    }

}