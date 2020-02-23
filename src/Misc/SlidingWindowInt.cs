// Find the max sum of K subarray elements    

using System;
using System.Collections.Generic;

public class IntSlidingWindow
{
    public void Run()
    {
        Console.WriteLine("Sliding Window Integer Mode");
        int[] inputArray = { 5, 3, 4, 6, 7, 2, 4, 8 };
        int holderCapacity = 3;
        Console.WriteLine("The list of integers are :");
        int result = GetMaxSubarray(inputArray, holderCapacity);
        Console.WriteLine("Result");
        Console.WriteLine(result);
    }

    private int GetMaxSubarray(int[] inputArray, int holderCapacity)
    {
        // Method 1 : Brute force
        // int maxSum = 0;
        // for (int i = 0; i <= inputArray.Length - holderCapacity; i++)
        // {
        //     int winSum = 0;
        //     for (int j = i; j <= i + holderCapacity - 1; j++)
        //     {
        //         winSum += inputArray[j];
        //     }
        //     maxSum = Math.Max(winSum, maxSum);
        // }
        // return maxSum;

        int maxSum = 0;
        int winSum = 0;
        for (int i=0; i< holderCapacity; i++)
        {
            winSum += inputArray[i];
        }

        for (int end=holderCapacity; end<= inputArray.Length-1; end++){
            winSum += inputArray[end] - inputArray[end - holderCapacity];
            maxSum = Math.Max(winSum, maxSum);
        }
        return maxSum;
    }
}