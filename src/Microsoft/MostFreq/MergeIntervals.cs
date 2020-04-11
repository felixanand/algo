using System.Collections.Generic;
// https://leetcode.com/problems/merge-intervals/
// 56. Merge Intervals

// Given a collection of intervals, merge all overlapping intervals.

// Example 1:

// Input: [[1,3],[2,6],[8,10],[15,18]]
// Output: [[1,6],[8,10],[15,18]]
// Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
// Example 2:

// Input: [[1,4],[4,5]]
// Output: [[1,5]]
// Explanation: Intervals [1,4] and [4,5] are considered overlapping.

using System;
using System.Linq;

public class Interval
{
    public int start { get; set; }
    public int end { get; set; }
}

public class MergeIntervals
{
    public void Run()
    {
        int[][] input = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
        List<Interval> result = input.Select(array => new Interval { start = array[0], end = array[1] }).ToList();

        List<Interval> final = Merge(result);
        foreach(Interval item in final)
        {
            Console.WriteLine(item.start + "," + item.end);
        }
        // foreach (int[] item in output)
        // {
        //     foreach (int itemFinal in item)
        //     {
        //         Console.Write(itemFinal + ",");
        //     }
        //     Console.WriteLine();
        // }
        

    }

    public List<Interval> Merge(List<Interval> intervals)
    {
        //O(nLgn) to sort
        intervals = intervals.OrderBy(i => i.start).ToList();
        // O(n) to update merged items in place
        for (int i = 1; i < intervals.Count; i++)
            if (intervals[i].start <= intervals[i - 1].end)
            {
                intervals[i].start = intervals[i - 1].start;
                intervals[i].end = Math.Max(intervals[i].end, intervals[i - 1].end);
                intervals[i - 1] = null; // Set null to be prepared removing later
            }
        int indexReserved = 0, indexCur = 0;
        while (indexReserved < intervals.Count && intervals[indexReserved] != null)
            indexReserved++;
        indexCur = indexReserved;
        // O(n) to move items to overwrite null items
        while (indexCur < intervals.Count)
        {
            while (indexCur < intervals.Count && intervals[indexCur] == null) indexCur++;
            if (indexCur == intervals.Count) break;
            intervals[indexReserved++] = intervals[indexCur];
            intervals[indexCur] = null;
        }
        // List remove at the last item costs O(1)
        while (intervals.Count > indexReserved)
            intervals.RemoveAt(intervals.Count - 1);
        return intervals;
    }
}