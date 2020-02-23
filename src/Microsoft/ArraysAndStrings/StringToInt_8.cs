//https://leetcode.com/problems/string-to-integer-atoi/

// Implement atoi which converts a string to an integer.

// The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

// The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

// If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

// If no valid conversion could be performed, a zero value is returned.

// Note:

// Only the space character ' ' is considered as whitespace character.
// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN (−231) is returned.
// Example 1:

// Input: "42"
// Output: 42
// Example 2:

// Input: "   -42"
// Output: -42
// Explanation: The first non-whitespace character is '-', which is the minus sign.
//              Then take as many numerical digits as possible, which gets 42.
// Example 3:

// Input: "4193 with words"
// Output: 4193
// Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.
// Example 4:

// Input: "words and 987"
// Output: 0
// Explanation: The first non-whitespace character is 'w', which is not a numerical 
//              digit or a +/- sign. Therefore no valid conversion could be performed.
// Example 5:

// Input: "-91283472332"
// Output: -2147483648
// Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer.
//              Thefore INT_MIN (−231) is returned.


using System;
using System.Text.RegularExpressions;

// WIP

public class StringToIntATOI_8
{
    public void Run()
    {
        string str = "4193 with words";
        int convValue = MyAtoi(str);
        Console.Write(convValue);
    }

    private int MyAtoi(string str)
    {
        if (String.IsNullOrEmpty(str.Trim())) return 0;
        double convertedlong = 0;
        int sign = 1;
        int startIndex = 0;

        // Remove all empty strings
        str = str.Replace(" ", string.Empty);
        str = (str.IndexOf(".") > 0) ? (str.Substring(0, str.IndexOf("."))) : str;

        // Check if the first letter is a character
        if (str.Length > 1)
        {
            string firstCharacter = str.Substring(0, 1);
            if (firstCharacter == "+" || firstCharacter == "-") startIndex++;
            if (!int.TryParse(str.Substring(startIndex, 1), out int n)) return 0;
        }
        else if (str.Length == 1)
        {
            if (!int.TryParse(str.Substring(startIndex, 1), out int n)) return 0;
        }

        // Remove all the words after the interger
        //Regex regEx = new Regex("[^0-9+-]");
        //char[] cStr = regEx.Replace(str, "").ToCharArray();
        char[] cStr = str.ToCharArray();
        if (cStr[0] == '-') sign = -1;

        int counter=0; // To keep track of position of the digit in accordacne with the loop count
        for (int i = startIndex; i <= cStr.Length - 1; i++)
        {
            if (Char.IsWhiteSpace(cStr[i]) || Char.IsLetter(cStr[i])) break;
            convertedlong += ((double)cStr[i] - (double)'0') * (double)Math.Pow(10, (cStr.Length - (++counter) - startIndex));
        }

        if (cStr.Length - 1 - counter > -1)
        {
            convertedlong = convertedlong / Math.Pow(10, cStr.Length -1 - counter);
        }

        if (sign == 1)
        {
            return (convertedlong > int.MaxValue ? int.MaxValue : (int)convertedlong);
        }
        else
        {
            return (sign * convertedlong < int.MinValue ? int.MinValue : sign * (int)convertedlong);
        }


    }
}
