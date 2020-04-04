using System.Linq;
// https://leetcode.com/problems/maximum-subarray/
// 53. Maximum Subarray

// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

// Example:

// Input: [-2,1,-3,4,-1,2,1,-5,4],
// Output: 6
// Explanation: [4,-1,2,1] has the largest sum = 6.

using System;

public class MaxSubArrayProb
{
    public void Run()
    {
        int[] inputData = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxSubArrayVal = MaxSubArray(inputData);
        Console.Write(maxSubArrayVal);
    }

    private int MaxSubArray(int[] nums)
    {
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            // Technique : Compare if current element is greater or current plus prev element is greater and assign vals
            // Refer video 
            if (nums[i - 1] + nums[i]   > nums[i])
                nums[i] += nums[i - 1];

            if (nums[i] > max)
                max = nums[i];
        }

        return max;
    }
}