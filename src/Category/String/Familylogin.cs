using System;
using System.Collections.Generic;
using System.Linq;

public class Familylogin
{
	public void Run()
    {
        string[] input = new string[] { "bag", "cbh", "sfe", "red", "cbh" };
        Console.WriteLine(GetPairs(input));
    }

    private int GetPairs(string[] input)
    {
        var totalCount = 0;

        var duplicateDataPointer = 0;
        var duplicateData = new string[input.Length];

        var hashSetData = new Stack<string>();
        var pairData = new Dictionary<string, string>();

        foreach(string element in input)
        {
            if (!(pairData.ContainsKey(element)))
            {
                pairData.Add(element, GetNextPosData(element));
            }
            else
            {
                duplicateData[duplicateDataPointer] = element;
                duplicateDataPointer++;
            }
        }

        foreach (var element in pairData)
        {
            var valueToCheck = element.Value;
            if (input.Any(valueToCheck.Contains))
            {
                hashSetData.Push(valueToCheck);
                totalCount++;
            }
        }

        foreach(var item in duplicateData)
        {
            if(hashSetData.Contains(item))
            {
                totalCount++;
            }
        }    

        return totalCount;
    }

    private string GetNextPosData(string input)
    {
        var splicedData = input.ToCharArray();
        char[] nextData = new char[input.Length];
        int pointer = 0;
        foreach(var letter in splicedData)
        {
            if (letter == 'z')
            {
                nextData[pointer] = 'a';
            }
            else
            {
                nextData[pointer] = (char)(((int)letter) + 1);
            }
            pointer++;
        }
        return new String(nextData);

    }
}

