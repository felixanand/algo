// https://leetcode.com/problems/product-of-array-except-self/
// 238. Product of Array Except Self

// Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

// Example:

// Input:  [1,2,3,4]
// Output: [24,12,8,6]
// Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

// Note: Please solve it without division and in O(n).

// Follow up:
// Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)

using System;

public class ArrayProductExceptSelf
{
    public void Run()
    {
        int[] input = { 1, 2, 3, 4 };
        int[] output = ProductExceptSelf(input);
        foreach (int element in output)
            Console.Write(" {0}", element);
    }

    private int[] ProductExceptSelf(int[] nums)
    {
        // The commented solution says time exceeded
        
        // int[] output = new int[nums.Length];
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int counter = 0;
        //     int val = 1;
        //     while (counter < nums.Length)
        //     {
        //         counter++;
        //         if (i == counter - 1) continue;
        //         val = val * nums[counter - 1];
        //     }
        //     output[i] = val;
        // }
        // return output;

        int[] arr = new int[nums.Length];
        
        // forward
        int prod = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prod *= nums[i];
            arr[i] = prod;
        }
        
        // backwards
        prod = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            arr[i] = prod * (i > 0 ? arr[i-1] : 1);
            prod *= nums[i];
        }
        
        return arr;
    }
}