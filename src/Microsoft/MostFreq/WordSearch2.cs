// https://leetcode.com/problems/word-search-ii/
// 212. Word Search II

// Given a 2D board and a list of words from the dictionary, find all words in the board.

// Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once in a word.

// Example:

// Input: 
// board = [
//   ['o','a','a','n'],
//   ['e','t','a','e'],
//   ['i','h','k','r'],
//   ['i','f','l','v']
// ]
// words = ["oath","pea","eat","rain"]

// Output: ["eat","oath"]


// Note:

// All inputs are consist of lowercase letters a-z.
// The values of words are distinct.


using System;
using System.Collections.Generic;

public class WordSearch2
{
    public void Run()
    {
        char[][] board = new char[][] { new char[] { 'o','a','a','n' },
         new char[] { 'e','t','a','e' },
         new char[] { 'i','h','k','r' },
         new char[] { 'i','f','l','v' } };
        string[] word = { "oath", "pea", "eat", "rain" };
        IList<string> data = FindWords(board, word); 
        foreach (string item in data)
        {
            Console.WriteLine(item);
        }
    }

    private IList<string> FindWords(char[][] board, string[] word)
    {
        IList<string> data = new List<string>();
        if (word.Length == 0)
            return data;

        if (board == null || board.Length == 0 && board[0].Length == 0)
            return data;

        int[,] visited = new int[board.Length, board[0].Length];

        for (int w = 0; w <= word.Length - 1; w++)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[w][0] && DFS(board, word[w], 0, i, j, visited))
                    {
                        if (!(data.Contains(word[w]))) data.Add(word[w]);
                        visited = new int[board.Length, board[0].Length];
                    }
                }
            }
        }
        return data;
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