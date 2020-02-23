// https://leetcode.com/problems/rotting-oranges/
// Solved using BFS & Queue

// using System;
// using System.Collections.Generic;

// public class RottingOranges
// {
//     public void Run()
//     {
//         Console.WriteLine("Rotting Oranges");
//         int[][] inputData = new int[3][];
//         inputData[0] = new int[] { 2, 1, 1 };
//         inputData[1] = new int[] { 1, 1, 0 };
//         inputData[2] = new int[] { 0, 1, 1 };
//         int minNumberOfMinutes = GetMinMinutes(inputData);
//         Console.WriteLine(minNumberOfMinutes);
//     }

//     class Orange
//     {
//         public int x;
//         public int y;
//         public int layer;
//         public Orange(int x, int y, int layer)
//         {
//             this.x = x;
//             this.y = y;
//             this.layer = layer;
//         }
//     }

//     int[] x = { 0, 0, -1, 1 };
//     int[] y = { 1, -1, 0, 0 };

//     private bool isOutSide(int[][] grid, int x, int y)
//     {
//         if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return true;
//         return false;
//     }

//     private int GetMinMinutes(int[][] grid)
//     {
//         int max = 0;

//         LinkedList<Orange> llOranges = new LinkedList<Orange>();
//         Queue<Orange> q = new Queue<Orange>(llOranges);

//         // Layer 1

//         for (int i = 0; i < grid.Length; i++)
//         {
//             for (int j = 0; j < grid[0].Length; j++)
//             {
//                 if (grid[i][j] == 2)
//                     q.Enqueue(new Orange(i, j, 0));
//             }
//         }

//         // Check for Subsequent Layers using BFS

//         while (!(q.Count == 0))
//         {
//             Orange current = q.Dequeue();
//             max = Math.Max(current.layer, max);

//             for (int k = 0; k < x.Length; k++)
//             {
//                 int row = current.x + x[k];
//                 int col = current.y + y[k];
//                 if (!isOutSide(grid, row, col) && grid[row][col] == 1)
//                 {
//                     grid[row][col] = 2;
//                     q.Enqueue(new Orange(row, col, current.layer++));
//                 }
//             }
//         }

//         for (int i = 0; i < grid.Length; i++)
//         {
//             for (int j = 0; j < grid[i].Length; j++)
//             {
//                 if (grid[i][j] == 1)
//                     return -1;
//             }
//         }
//         return max;
//     }

// }


using System;
using System.Collections.Generic;

public class RottingOranges
{
    public void Run()
    {
        Console.WriteLine("Rotting Oranges");
        int[][] inputData = new int[3][];
        inputData[0] = new int[] { 2, 1, 1 };
        inputData[1] = new int[] { 1, 1, 0 };
        inputData[2] = new int[] { 0, 1, 1 };
        int minNumberOfMinutes = GetMinMinutes(inputData);
        Console.WriteLine(minNumberOfMinutes);
    }

    // Queue to hold all Rotten Oranges Coordinates
    Queue<int[]> q = new Queue<int[]>();
    // Good Oranges
    int remainingGoodOranges = 0;
    // Minutes taken to Rotten
    int minutesTaken = 0;

    // Get Minutes taken to Rotten entire orange set
    public int GetMinMinutes(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 2)
                    q.Enqueue(new int[] { i, j });
                else if (grid[i][j] == 1)
                    remainingGoodOranges++;
            }
        }

        while (remainingGoodOranges > 0)
        {
            var size = q.Count;
            minutesTaken++;

            if (size == 0 && remainingGoodOranges > 0)
                return -1;

            while (size > 0)
            {
                var curItem = q.Dequeue();
                size--;
                var x = curItem[0];
                var y = curItem[1];
                CovertToRotten(grid, x + 1, y); //up
                CovertToRotten(grid, x - 1, y); //down
                CovertToRotten(grid, x, y - 1); //left
                CovertToRotten(grid, x, y + 1); //right
            }
        }
        return minutesTaken;
    }

    public void CovertToRotten(int[][] grid, int x, int y)
    {
        if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
            return;

        if (grid[x][y] == 1)
        {
            grid[x][y] = 2;
            remainingGoodOranges--;
            q.Enqueue(new int[] { x, y });
        }
    }
}