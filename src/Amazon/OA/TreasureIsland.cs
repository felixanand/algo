// https://leetcode.com/discuss/interview-question/347457

 /**
     * Time Complexity: O(R * C) where R is number of rows and C is no of columns in map
     * Space Complexity: O(R * C) where R is number of rows and C is no of columns in map
  */

using System;
using System.Collections.Generic;

public class TreasureIsland
{
    public void Run()
    {
        Console.WriteLine(getMinDistanceToTreasureIsland(
            new char[][] { new char[] {'O', 'O', 'O', 'O'}, new char[] {'D', 'O', 'D', 'O'}, new char[] {'O', 'O', 'O', 'O'}, new char[] {'X', 'D', 'D', 'O'} }
        ));
        Console.WriteLine(getMinDistanceToTreasureIsland(
            new char[][] { new char[] {'O', 'X'}, new char[]  {'O', 'O'}, new char[] {'O', 'O'}, new char[] {'X', 'D', 'D', 'O'} }
        ));
    }

    private int getMinDistanceToTreasureIsland(char[][] map)
    {
        if (map == null || map.Length == 0) return 0;

        // Possible Sailing Directions
        int[][] sides = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };
        int steps = 0;

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { 0, 0 });

        // Tracking end of the step
        queue.Enqueue(new int[] { -1, -1 });

        // Mark as visited
        map[0][0] = 'D';

        while (queue.Count != 0)
        {
            int[] e = queue.Dequeue();
            int row = e[0], col = e[1];

            if (row == -1 && col == -1)
            // End of Queue so incrementing the step
            // If there are no more elements except the end , break
            {
                ++steps;
                if (queue.Count != 0)
                {
                    queue.Enqueue(new int[] { -1, -1 });
                }
                else
                    break;
            }
            else if (map[row][col] == 'X')
            {
                // Return the steps if treasure is found
                return steps;
            }
            else
            {
                // Sail on all possible directions
                foreach (int[] side in sides)
                {
                    int newRow = row + side[0], newCol = row + side[1];
                    if (isSafeToSail(newRow, newCol, map))
                    {
                        queue.Enqueue(new int[] { newRow, newCol });
                        map[row][col] = 'D';
                    }
                }
            }
        }
        return -1;
    }

    private bool isSafeToSail(int row, int col, char[][] map)
    {
        return (row >= 0 && row < map.Length && col >= 0 && col < map[row].Length && map[row][col] != 'D');
    }
}