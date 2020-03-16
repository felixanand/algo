namespace DSAlgo.Helper.Arrays
{
    using System;
    public static class Arrays
    {
        public static void Print2DArrayData(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}