 // https://leetcode.com/problems/valid-palindrome/

//  Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

// Note: For the purpose of this problem, we define empty string as valid palindrome.

// Example 1:

// Input: "A man, a plan, a canal: Panama"
// Output: true
// Example 2:

// Input: "race a car"
// Output: false

using System;
using System.Text.RegularExpressions;

public class ValidPalindrome_LC125{
    public void Run(){
        string s = "A man, a plan, a canal: Panama";
        bool isValid = IsPalindrome(s);
        Console.WriteLine(isValid);
    }

    private bool IsPalindrome(string s){

        Regex regex = new Regex("[^a-zA-Z0-9]");
        char[] dataInChar = regex.Replace(s,"").ToLower().ToCharArray();
        char[] originalArray = new char[dataInChar.Length];
        Array.Copy(dataInChar, originalArray, dataInChar.Length);
        Array.Reverse(dataInChar);

        return (String.Equals(new string(dataInChar), new string(originalArray)));
    }
}
