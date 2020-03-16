
// https://leetcode.com/problems/letter-combinations-of-a-phone-number/

// Given a string containing digits from 2-9 inclusive, return all possible
//  letter combinations that the number could represent.

// // A mapping of digit to letters (just like on the telephone buttons) is given below. 
// Note that 1 does not map to any letters.

// Example:

// Input: "23"
// Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
// Note:

// Although the above answer is in lexicographical order, your answer could be in any order you want.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class PhoneNumbers_17
{
    public void Run()
    {
        string digits = "23";
        IList<string> result = LetterCombinations(digits);
        foreach (string item in result)
        {
            Console.Write(item + "  ");
        }
    }

    public IList<string> LetterCombinations(string digits)
    {
        // Create the result to be returned
        IList<string> result = new List<string>();
        // Some basic check
        if (digits == null || digits.Length == 0)
        {
            return result;
        }
        // Create the dict based on index 
        string[] mapping = new string[] {
            "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"
        };
        // Call recursive function
        RecursiveLetterCreation(result, digits, "", 0, mapping);
        return result;
    }

    private void RecursiveLetterCreation(IList<string> result, string digits, string currString, int index, string[] mapping)
    {
        // When to stop this recursion
        if (index == digits.Length)
        {
            result.Add(currString);
            return;
        }

        // Get Letters at current index
        String letters = mapping[digits[index] - '0'];
        // Recursively add 
        for (int i = 0; i < letters.Length; i++)
        {
            RecursiveLetterCreation(result, digits, currString + letters[i], index + 1, mapping);
        }

    }

}