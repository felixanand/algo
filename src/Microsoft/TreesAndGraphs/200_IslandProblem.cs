
// https://leetcode.com/problems/number-of-islands/

using System;

public class IslandProblem
{
    public void Run()
    {
        Console.WriteLine("Island Problem");
        //char[][] earth = new char[][] { "11110".ToCharArray(), "11010".ToCharArray(), "11000".ToCharArray(), "00000".ToCharArray() };
        char[][] earth = new char[][] { "11000".ToCharArray(), "11000".ToCharArray(), "00100".ToCharArray(), "00011".ToCharArray() };
        Console.WriteLine("No of Islands: {0}", NumIslands(earth));
    }

    private int NumIslands(char[][] grid)
    {
        int numOfIslands = 0;
        // Use Breadth First search method
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    numOfIslands++;
                    BFS(grid, i, j);
                }
            }
        }
        return numOfIslands;
    }

    private void BFS(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            return;

        grid[i][j] = '0';
        BFS(grid, i + 1, j); // Up
        BFS(grid, i - 1, j); // Down
        BFS(grid, i, j - 1); // Left
        BFS(grid, i, j + 1); // Right
    }
}