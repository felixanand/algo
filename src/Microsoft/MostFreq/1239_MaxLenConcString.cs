// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
// Incorrect solution - Need to fix

using System;
using System.Collections.Generic;
using System.Linq;

public class MaxLenConcString
{
    public void Run()
    {
        Console.WriteLine("Maximum Length of Concatenated String :");
        string[] input = new string[] { "cha", "r", "act", "ers" };
        Console.WriteLine("Max length of possible concatented string: {0}", MaxLength(input));
    }

    private int MaxLength(IList<string> arr)
    {
        int maxLength = 0;
        DFS(arr, ref maxLength, 0, "");
        return maxLength;
    }

    private void DFS(IList<string> arr, ref int maxLength, int startIndex, string newString)
    {
        if (!isUniqueWord(newString)) return;

        maxLength = maxLength > newString.Length ? maxLength : newString.Length;

        for (int i = startIndex; i < arr.Count; i++)
        {
            DFS(arr, ref maxLength, i + 1, newString + arr[i]);
        }
    }

    private bool isUniqueWord(string input)
    {
        HashSet<char> data = new HashSet<char>(input);
        return (data.Count() == input.Length);
    }
}
