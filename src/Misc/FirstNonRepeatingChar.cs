// https://leetcode.com/problems/first-unique-character-in-a-string/

using System;

public class FirstNonRepeatingCharacter
{
    public void Run()
    {
        Console.WriteLine("First Non Repeating Character");
        string input = "loveleetcode";
        int outputIndex = firstUniqChar(input);
        Console.WriteLine(outputIndex);
    }

    private int firstUniqChar(string s)
    {
        for (int i=0;i <= s.Length-1; i++)
        {
            if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
            return i; 
        }
        return -1;
    }
}