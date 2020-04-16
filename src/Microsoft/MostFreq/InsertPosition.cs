// https://leetcode.com/problems/search-insert-position/
// 35. Search Insert Position

// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

// You may assume no duplicates in the array.

// Example 1:

// Input: [1,3,5,6], 5
// Output: 2
// Example 2:

// Input: [1,3,5,6], 2
// Output: 1
// Example 3:

// Input: [1,3,5,6], 7
// Output: 4
// Example 4:

// Input: [1,3,5,6], 0
// Output: 0

using System;

public class SearchInsertPosition
{
    public void Run()
    {
        // int[] input = { 1, 3, 5 };
        // int k = 4;
        int[] input = { 1, 3, 5 ,6};
        int k = 2;
        Console.WriteLine(SearchInsert(input, k));
    }

    private int SearchInsert(int[] nums, int target)
    {
        int countOfElements = nums.Length;
        int returnIndex = 0;

        if (countOfElements == 0)
        {
            return returnIndex;
        }
        else if (target > nums[countOfElements - 1])
        {
            return countOfElements;
        }
        else if (target == nums[countOfElements - 1])
        {
            return countOfElements - 1;
        }
        else
        {
            return getIndexOfElement(nums, target, 0, nums.Length - 1);
        }
    }

    private int getIndexOfElement(int[] input, int k, int start, int end)
    {

        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (mid == 0 && k < input[mid])
            {
                return mid;
            }
            else if (mid == 0 && k > input[mid])
            {
                return 1;
            }

            if ((input[mid]) == k)
            {
                return mid;
            }
            else if ((input[mid - 1] < k && input[mid + 1] > k))
            {
                if (input[mid] < k) 
                {
                    return mid + 1;
                }
                return mid;
            }
            else if (input[mid] < k)
            {
                return getIndexOfElement(input, k, mid + 1, end);
            }
            else if (input[mid] > k)
            {
                return getIndexOfElement(input, k, start, mid - 1);
            }
        }
        return -1;
    }

}