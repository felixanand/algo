using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class MostCommonWordAlgo
{
    public void Run()
    {
        string paragraph = "Bob. hIt, baLl"; //"Bob hit a ball, the hit BALL flew far after it was hit.";
        string[] bannedWord = new string[] { "bob", "hit" };
        string resultString = MostCommonWord(paragraph, bannedWord);
        Console.WriteLine(resultString);
    }

    public string MostCommonWord(string paragraph, string[] banned)
    {
        string requiredWord = "";
        HashSet<string> bannedWord = new HashSet<string>(banned);
        Dictionary<string, int> wordCollection = new Dictionary<string, int>();
        Regex reg = new Regex("[^a-zA-Z]");
        string[] splitData = reg.Replace(paragraph," ").ToLower().Split(" ");
        foreach (string word in splitData)
        {            
            if (!bannedWord.Contains(word) && word != string.Empty)
            {
                if (wordCollection.ContainsKey(word))
                {
                    wordCollection[word]++ ;
                }
                else
                {
                    wordCollection.Add(word, 1);
                }
            }
        }
        requiredWord = wordCollection.FirstOrDefault(x=>x.Value == wordCollection.Values.Max()).Key;
        return requiredWord;
    }

}