using System;

public class CircularArrayPrint
{
    public void Run()
    {
        char[] inputArray = { 'A', 'B', 'C', 'D', 'E', 'F' };
        int startIndex = 3;
        PrintCircularArray(inputArray, startIndex, inputArray.Length);
    }

    public void PrintCircularArray(char[] input, int startIndex, int count)
    {
        char[] dummyArray = new char[2 * count];
        int pointer = 0;
        for (int i = 0; i < dummyArray.Length; i++)
        {
            if (pointer >= count) pointer = 0;
            dummyArray[i] = input[pointer++];
        }

        for(int j=startIndex; j < startIndex + count; j++)
        {
            Console.Write(dummyArray[j]);
        }
    }
}