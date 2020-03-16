using System;
using System.Collections.Generic;

public class SpiralMatrix
{
    public void Run()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5, 6 };
        matrix[2] = new int[] { 7, 8, 9 };
        IList<int> res = GetResult(matrix);
        foreach (int item in res)
        {
            Console.Write(item);
        }
    }

    private IList<int> GetResult(int[][] matrix)
    {
        IList<int> res = new List<int>();
        if (matrix.Length == 0) return res;
        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;
        int direction = 0;

        while (top <= bottom && left <= right)
        {
            if (direction == 0) // Traverse Row Left to Right
            {
                for (int i = left; i <= right; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top++;
            }
            if (direction == 1) // Traverse Column Top to Bottom
            {
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(matrix[i][right]);
                }
                right--;
            }
            if (direction == 2) // Travese Row Right to Left
            {
                for (int i = right; i >= left; i--)
                {
                    res.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            if (direction == 3) // Traverse Bottom to Top
            {
                for (int i = bottom; i >= top; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }

            direction = ( direction + 1 ) % 4;
        }

        return res;
    }
}
