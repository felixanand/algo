// Kth missing element in an sorted array

using System;
using System.Collections.Generic;

public class KthMissing
{
    public void Run()
    {
        Console.WriteLine("Kth Missing Element");
        int[] inputData = { 1,3 };
        int pos = 1;
        Console.WriteLine(GetMissingElement(inputData, pos));
    }

    private int GetMissingElement(int[] inputData, int pos)
    {
        HashSet<int> data = new HashSet<int>(inputData);
        int counter = 0;
        for (int i = inputData[0]; i <= inputData[inputData.Length - 1]; i++)
        {
            if (!data.Contains(i) && (++counter == pos)) return i;

        }
        return -1;
    }
}