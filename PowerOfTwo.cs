// https://leetcode.com/problems/power-of-two/

using System;

public class PowerOfTwo{
    public void Run(){
        Console.WriteLine("Power of Two");
        int inputValue = 1;
        bool result = IsPowerOfTwo(inputValue);
        Console.WriteLine(result);
    }

    private bool IsPowerOfTwo(int n)
    {
        int i=1;
        while (i < n)
        {
            i = i * 2;
        }
        return (i == n);
    }
}