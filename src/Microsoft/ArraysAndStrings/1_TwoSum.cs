using System;
using System.Collections.Generic;

// https://leetcode.com/problems/two-sum/

public class TwoSumProblem
{
    public void Run()
    {
        Console.WriteLine("Two Sum Probelm:");
        int[] inputArray = { 3,3 };
        int numberToFind = 6;
        int[] Result = TwoSum(inputArray, numberToFind);
        if (Result.Length > 1)
        {
            Console.WriteLine("Result: ");
            foreach (int data in Result) Console.WriteLine(data);
        }
    }

    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return new int[] {0,0};

        // Solution 2
        // ----------

        //Array.Sort(nums);
        // int compliment = 0;
        // IDictionary<int, int> dataDict = new Dictionary<int, int>();
        // for (int i = 0; i <= nums.Length - 1; i++)
        // {
        //     //if (dataDict.ContainsKey(nums[i])) return new int[] {0,0};
        //     dataDict.Add(nums[i], i);
        // }
        // for (int i = 0; i <= nums.Length - 1; i++)
        // {
        //     compliment = target - nums[i];
        //     if (dataDict.ContainsKey(compliment) && dataDict[compliment] != i)
        //     {
        //         return new int[] {i, dataDict[compliment]};
        //     }
        // }
        // return new int[] {0,0};          
    }
}