// https://leetcode.com/problems/median-of-two-sorted-arrays/
// 4. Median of Two Sorted Arrays

using System;

public class MedianOfSortedArray
{
    public void Run()
    {
        int[] n1 = new int[] { 1, 2 };
        int[] n2 = new int[] { 3, 4 };
        double median = FindMedianSortedArrays(n1, n2);
        Console.WriteLine(median);
    }

    private double FindMedianSortedArrays(int[] n1, int[] n2)
    {
        int p1 = 0;
        int p2 = 0;
        int m = n1.Length;
        int n = n2.Length;
        int[] merged = new int[m + n];
        int mergedPos = 0;

        while (p1 < m || p2 < n)
        {
            if (p1 < m && p2 < n)
            {
                merged[mergedPos++] = (n1[p1] < n2[p2]) ? n1[p1++] : n2[p2++];
            }
            else if (p1 < m && p2 >= n)
            {
                merged[mergedPos++] = n1[p1++];
            }
            else
            {
                merged[mergedPos++] = n2[p2++];
            }
        }

        int totLength = m + n;
        if (totLength % 2 == 0) return (double)(merged[totLength / 2] + merged[totLength / 2 - 1]) / 2.0;
        else return (double)(merged[totLength / 2]);
    }
}