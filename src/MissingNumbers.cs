// Leetcode 
// https://leetcode.com/problems/missing-number/

using System;
using System.Collections.Generic;
using System.Linq;

public class MissingNumbers
{
    public void Run()
    {
        Console.WriteLine("Missing Numbers");
        int[] numbers = new int[] {1,0,3};
        int result = MissingNumber(numbers);
        Console.WriteLine(result);
    }

    private int MissingNumber(int[] nums)
    {
        if (nums == null || nums.Length == 0) return -1;
        // Runs in 108 ms
        HashSet<int> data = new HashSet<int>(nums);
        // Why nums.Length + 1 ==> That is because we miss a number, so we add one in addition to total given length
        for (int i=0; i<= nums.Length + 1; i++)
        {
            if(!data.Contains(i))
                return i;
        }
        return -1;
        
        // Runs in 120 ms
        // int mNum = nums.Max();
        // int sum = (mNum*(mNum+1))/2;
        // int currentSum = 0;
        // for(int i=0; i<= nums.Length-1; i++)
        // {
        //     currentSum += nums[i];
        // }
        // return(( sum - currentSum) < 0 ? -1 : (sum-currentSum));
    }
}