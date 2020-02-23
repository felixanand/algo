// Binary Array Search Implementation
using System;

public class BinaryArraySearch
{
    public void Run()
    {
        Console.WriteLine("Binary Array Search");
        int[] initialData = {14,17,3,4,7,12,4,5};
        int valueToBeSearched = 4;
        Array.Sort(initialData);
        Console.WriteLine("Result : {0}", IsDataPresent(initialData, valueToBeSearched,0, initialData.Length-1));
    }

    bool IsDataPresent(int[] data, int findValue,int start, int end)
    {
        if (start > end) return false;
        int mid = (start + end)/2;

        if(data[mid] == findValue) {
            return true;
            }
            else if (findValue < data[mid])
            {
               return IsDataPresent(data, findValue, start, mid - 1);
            }
            else if (findValue > data[mid])
            {
               return IsDataPresent(data, findValue, mid + 1, end);
            }
        return false;
    }
}