// Check the first occurring duplicate - the duplicate number should occur first as well

using System;
using System.Collections.Generic;

public class FirstDuplicate
{
    public void Run()
    {
        Console.WriteLine("First Duplicate with twist");
        int[] inputData = { 5, 3, 4, 2, 3, 5, 7 };
        int result = GetFirstDuplicate(inputData);
        Console.WriteLine(result);
    }

    private int GetFirstDuplicate(int[] inputData)
    {
        //Option 1

        // int leastIndex = inputData.Length + 1;
        // for (int i = 0; i <= inputData.Length - 1; i++)
        // {
        //     for (int j = i + 1; j <= inputData.Length - 1; j++)
        //     {
        //         if (inputData[i] == inputData[j])
        //         {
        //             if (j < leastIndex) leastIndex = j;
        //         }
        //     }
        // }
        // return (leastIndex > -1) ? inputData[leastIndex] : -1;

        // Option 2

        HashSet<int> allData = new HashSet<int>();
        for (int i=0; i<= inputData.Length; i++)
        {
            if (allData.Contains(inputData[i]))
            {
                return inputData[i];
            }
            else
                allData.Add(inputData[i]);
        }
        return -1;
    }
}