// https://leetcode.com/problems/reverse-integer/
// 7. Reverse Integer

// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).



// Example 1:

// Input: x = 123
// Output: 321

using System;
using System.Collections.Generic;

public class ReverseIntegers
{
    public void Run()
    {
        int inputValue = 543;
        int result = InvertInteger(inputValue);
        Console.WriteLine(result);
    }

    private int InvertInteger(int x)
    {
        long res = 0;
        while (x != 0)
        {
            res *= 10;
            res += x % 10;
            x /= 10;
        }
        return (int)res == res ? (int)res : 0;
    }
}