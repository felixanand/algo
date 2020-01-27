// Grouped Anangrams
// https://leetcode.com/problems/group-anagrams/

using System;
using System.Collections.Generic;

public class GroupedAnangrams
{

    public void Run()
    {
        Console.WriteLine("Grouped Anangrams");
        string[] inputData = { "eat", "tea", "tan", "ate", "nat", "bat" };
        IList<IList<string>> finalResult = GroupAnangrams(inputData);
        foreach (List<string> item in finalResult)
        {
            foreach (string i in item)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    public IList<IList<string>> GroupAnangrams(string[] strs)
    {
        IList<IList<string>> finalResult = new List<IList<string>>();
        string fullWord= string.Empty;
        Dictionary<string, IList<string>> dataHolder = new Dictionary<string, IList<string>>();

        foreach (string word in strs)
        {
            char[] arrangedChars = word.ToCharArray();
            Array.Sort(arrangedChars);
            fullWord = new string(arrangedChars);
            if (!dataHolder.ContainsKey(fullWord))  dataHolder.Add(fullWord, new List<string>());
            dataHolder[fullWord].Add(word);
        }
        foreach (List<string> data in dataHolder.Values)
        {
            finalResult.Add(data);
        }
        return finalResult;
    }
}