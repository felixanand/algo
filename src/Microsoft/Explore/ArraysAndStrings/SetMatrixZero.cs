using System.Linq;
// 73. Set Matrix Zeroes
// https://leetcode.com/problems/set-matrix-zeroes/

// Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in-place.

// Example 1:

// Input: 
// [
//   [1,1,1],
//   [1,0,1],
//   [1,1,1]
// ]
// Output: 
// [
//   [1,0,1],
//   [0,0,0],
//   [1,0,1]
// ]

using DSAlgo.Helper.Arrays;
using System.Collections.Generic;

public class SetMatrixZero
{
    public void Run()
    {
        int[][] inputData = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };
        SetZeroes(inputData);

        Arrays.Print2DArrayData(inputData);
    }

    private void SetZeroes(int[][] matrix)
    {
        HashSet<int> iSet = new HashSet<int>();
        HashSet<int> jSet = new HashSet<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    iSet.Add(i);
                    jSet.Add(j);
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (iSet.Contains(i) || jSet.Contains(j))
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}