// https://leetcode.com/problems/word-search/
// 79. Word Search

// Given a 2D board and a word, find if the word exists in the grid.

// The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

// Example:

// board =
// [
//   ['A','B','C','E'],
//   ['S','F','C','S'],
//   ['A','D','E','E']
// ]

// Given word = "ABCCED", return true.
// Given word = "SEE", return true.
// Given word = "ABCB", return false.

using System;

public class WordSearch
{
    public void Run()
    {
        char[][] board = new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        string word = "ABCCED";
        word = "SEE";
        word = "ABCB";

        Console.WriteLine(Exist(board, word));
    }

    private bool Exist(char[][] board, string word)
    {
        if (string.IsNullOrEmpty(word))
            return true;

        if (board == null || board.Length == 0 && board[0].Length == 0)
            return false;

        int[,] visited = new int[board.Length, board[0].Length];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && DFS(board, word, 0, i, j, visited))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int countPointer, int i, int j, int[,] visited)
    {
        if (word.Length == countPointer) return true;

        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || visited[i, j] == 1 || board[i][j] != word[countPointer])
            return false;


        visited[i, j] = 1;
        bool ifExists = DFS(board, word, countPointer + 1, i + 1, j, visited) ||
                        DFS(board, word, countPointer + 1, i - 1, j, visited) ||
                        DFS(board, word, countPointer + 1, i, j + 1, visited) ||
                        DFS(board, word, countPointer + 1, i, j - 1, visited);
       
        if (ifExists == true) return ifExists;
        
        // Restore current pos to unvisited
        visited[i, j] = 0;
        return false;
    }
}