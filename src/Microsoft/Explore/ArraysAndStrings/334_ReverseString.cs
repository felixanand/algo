//https://leetcode.com/problems/reverse-string/

using System;
public class ReverseString_334
{
    public void Run()
    {
        char[] s = new char[] { 't', 'h', 'e' };
        ReverseString(s);
        foreach (char t in s)
        {
            Console.WriteLine(s);
        }
    }

    private void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
    }
}