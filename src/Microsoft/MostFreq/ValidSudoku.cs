// https://leetcode.com/problems/valid-sudoku/
// 36. Valid Sudoku

using System;
using System.Collections.Generic;

public class ValidSudoku
{
    public void Run()
    {
        char[][] board = new char[][] {("53..7....").ToCharArray(),("6..195...").ToCharArray(),(".98....6.").ToCharArray(),
        ("8...6...3").ToCharArray(),("4..8.3..1").ToCharArray(),("7...2...6").ToCharArray(),
        (".6....28.").ToCharArray(), ("...419..5").ToCharArray(), ("....8..79").ToCharArray()};
        Console.WriteLine(IsValidSudoku(board));
    }

    private bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char currentVal = board[i][j];
                if (currentVal != '.')
                {
                    if (
                       (!seen.Add(currentVal + " is found at row " + i))
                    || (!seen.Add(currentVal + " is found at col " + j))
                    || (!seen.Add(currentVal + " is found at box " + i / 3 + "-" + j / 3))
                        )
                        return false;
                }
            }
        }
        return true;
    }


}
