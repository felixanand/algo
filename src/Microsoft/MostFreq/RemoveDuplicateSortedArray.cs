// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// 26. Remove Duplicates from Sorted Array

using System;

public class RemoveDuplicateSortedArray
{
    public void Run()
    {
        int[] input = { 1, 1, 2 };
        int res = RemoveDuplicates(input);
        Console.Write(res);
    }

    private int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int indexWhereUniqueElementIsInserterd = 1; // This is because we will not modify the firt element
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // If next element are not same, place that element at the intended index
            if (nums[i] != nums[i + 1])
            {
                nums[indexWhereUniqueElementIsInserterd++] = nums[i + 1];
            }

        }
        return indexWhereUniqueElementIsInserterd;
    }
}