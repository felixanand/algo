// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array

// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

// (i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).

// Find the minimum element.

// You may assume no duplicate exists in the array.

// Example 1:

// Input: [3,4,5,1,2] 
// Output: 1
// Example 2:

// Input: [4,5,6,7,0,1,2]
// Output: 0


using System;
public class MinRotatedSortedArray
{
    public void Run()
    {
        int[] nums = new int[] { 3, 4, 5, 1, 2 };
        Console.Write(FindMin(nums));
    }

    private int FindMin(int[] nums)
    {
        if (nums.Length == 0) return -1;

        if (nums.Length == 1) return nums[0];

        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int midpoint = left + (right - left) / 2;

            if (midpoint > 0 && nums[midpoint] < nums[midpoint - 1])
            {
                return nums[midpoint];
            }
            else if (nums[left] <= nums[midpoint] && nums[midpoint] > nums[right])
            {
                left = midpoint + 1;
            }
            else
            {
                right = midpoint - 1;
            }
        }
        return nums[left];

    }
}