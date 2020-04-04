// https://leetcode.com/problems/move-zeroes/
// 283. Move Zeroes

using System;
using System.Collections.Generic;

public class MoveZeroesProblem
{
    public void Run()
    {
        int[] input = { 0, 1, 0, 3, 12 };
        int[] output = MoveZeroes(input);
        foreach (int item in output) Console.Write(item);
    }

    private int[] MoveZeroes(int[] nums)
    {
        int pointerPosition = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                nums[pointerPosition++] = nums[i];
            }
        }
        while (pointerPosition <= nums.Length - 1)
        {
            nums[pointerPosition++] = 0;
        }
        return nums;
    }
}