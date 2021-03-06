//https://leetcode.com/problems/sort-colors/

// Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.

// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

// Note: You are not suppose to use the library's sort function for this problem.

// Example:

// Input: [2,0,2,1,1,0]
// Output: [0,0,1,1,2,2]
// Follow up:

// A rather straight forward solution is a two-pass algorithm using counting sort.
// First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
// Could you come up with a one-pass algorithm using only constant space?

using System;
public class SortColors_75
{
    public void Run()
    {
        int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
        SortColors(nums);
        foreach (int item in nums)
        {
            Console.Write(item);
        }
    }

    // TODO : Need to find better solution
    private void SortColors(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    int temp = nums[i];
                    nums[i]=nums[j];
                    nums[j] = temp;                    
                }
            }
        }
    }
}