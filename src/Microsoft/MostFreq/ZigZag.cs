// https://leetcode.com/problems/zigzag-conversion/
// 6. ZigZag Conversion

// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

// P   A   H   N
// A P L S I I G
// Y   I   R
// And then read line by line: "PAHNAPLSIIGYIR"

// Write the code that will take a string and make this conversion given a number of rows:

// string convert(string s, int numRows);
// Example 1:

// Input: s = "PAYPALISHIRING", numRows = 3
// Output: "PAHNAPLSIIGYIR"
// Example 2:

// Input: s = "PAYPALISHIRING", numRows = 4
// Output: "PINALSIGYAHRPI"
// Explanation:

// P     I    N
// A   L S  I G
// Y A   H R
// P     I

using System;
using System.Text;

public class ZigZag
{
    public void Run()
    {
        string s = "PAYPALISHIRING";
        int numRows = 3;
        Console.WriteLine("Output is {0}", Convert(s, numRows));
    }

    private string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        StringBuilder sb = new StringBuilder();

        for (int r = 0; r < numRows; r++)
        {
            int up = 2 * r;
            int down = 2 * (numRows - r - 1);

            if (down == 0 || up == 0)
                down = up = Math.Max(down, up);

            bool isDown = true;

            for (int x = r; x < s.Length; isDown = !isDown)
            {
                sb.Append(s[x]);
                x += isDown ? down : up;
            }
        }

        return sb.ToString();
    }
}