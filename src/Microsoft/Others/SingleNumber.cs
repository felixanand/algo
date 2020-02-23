// https://leetcode.com/problems/single-number/

using System;
using System.Collections.Generic;

public class SingleNumber
{

    public void Run()
    {
        Console.WriteLine("Single Number");
        int[] inputArray = new int[] { 2, 2, 1 };
        int theValue = GetSingleNumber(inputArray);
        Console.WriteLine(theValue);
    }

    private int GetSingleNumber(int[] nums)
    {
        List<int> data = new List<int>();
        foreach (int element in nums)
        {
            if (data.Contains(element))
            {
                data.Remove(element);
            }
            else
            {
                data.Add(element);
            }
        }
        if (data.Count != 0)
            return data[0];
        else
            return -1;
    }

}
