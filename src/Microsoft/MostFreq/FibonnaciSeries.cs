// https://leetcode.com/problems/fibonacci-number/
// 509. Fibonacci Number

using System;
using System.Collections.Generic;
public class Fibonacci
{
    Dictionary<int, int> holder = new Dictionary<int, int>();

    public void Run()
    {
        int input = 5;
        Console.WriteLine("Fibonacci Number at {0}th position is {1}", input, Fib(input));
    }

    private int Fib(int N)
    {
        // Used Dynamic Programming

        int result = 1;
        if (holder.ContainsKey(N)) return holder[N];
        if (N < 1) return 0;
        if (!(N == 1 || N == 2))
        {
            result = Fib(N - 1) + Fib(N - 2);
        }
        holder.Add(N, result);
        return result;
    }
}