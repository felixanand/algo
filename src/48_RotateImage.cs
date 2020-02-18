// https://leetcode.com/problems/rotate-image/

// You are given an n x n 2D matrix representing an image.

// Rotate the image by 90 degrees (clockwise).

// Note:

// You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.

// Example 1:

// Given input matrix = 
// [
//   [1,2,3],
//   [4,5,6],
//   [7,8,9]
// ],

// rotate the input matrix in-place such that it becomes:
// [
//   [7,4,1],
//   [8,5,2],
//   [9,6,3]
// ]


using System;

public class RotateImage
{
    public void Run()
    {
        int[][] inputData = new int[3][];
        inputData[0] = new int[] { 1, 2, 3 };
        inputData[1] = new int[] { 4, 5, 6 };
        inputData[2] = new int[] { 7, 8, 9 };
        Rotate(inputData);
    }

    // 2 step process
    // Interchange row column ( transpose )
    // Shift items from one end to another
    private void Rotate(int[][] matrix)
    {
        int N = matrix.Length;
        for (int i = 0; i < N; i++)
        {
            for (int j = i; j < N; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < (N/2); j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][N-1-j];
                matrix[i][N-1-j] = temp;
            }
        }
    }
}
