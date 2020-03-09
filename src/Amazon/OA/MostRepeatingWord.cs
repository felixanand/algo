// https://leetcode.com/discuss/interview-question/460127/

// You work on a team whose job is to understand the most sought after toys for the holiday season. A teammate of yours has built a webcrawler that extracts a list of quotes about toys from different articles. You need to take these quotes and identify which toys are mentioned most frequently. Write an algorithm that identifies the top N toys out of a list of quotes and list of toys.

// Your algorithm should output the top N toys mentioned most frequently in the quotes.

// Input:
// The input to the function/method consists of five arguments:

// numToys, an integer representing the number of toys
// topToys, an integer representing the number of top toys your algorithm needs to return;
// toys, a list of strings representing the toys,
// numQuotes, an integer representing the number of quotes about toys;
// quotes, a list of strings that consists of space-sperated words representing articles about toys

// Output:
// Return a list of strings of the most popular N toys in order of most to least frequently mentioned

// Note:
// The comparison of strings is case-insensitive. If the value of topToys is more than the number of toys, return the names of only the toys mentioned in the quotes. If toys are mentioned an equal number of times in quotes, sort alphabetically.

// Example 1:

// Input:
// numToys = 6
// topToys = 2
// toys = ["elmo", "elsa", "legos", "drone", "tablet", "warcraft"]
// numQuotes = 6
// quotes = [
// "Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
// "The new Elmo dolls are super high quality",
// "Expect the Elsa dolls to be very popular this year, Elsa!",
// "Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
// "For parents of older kids, look into buying them a drone",
// "Warcraft is slowly rising in popularity ahead of the holiday season"
// ];

// Output:
// ["elmo", "elsa"]

// Explanation:
// elmo - 4
// elsa - 4
// "elmo" should be placed before "elsa" in the result because "elmo" appears in 3 different quotes and "elsa" appears in 2 different quotes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MostRepeatingWords
{
    IDictionary<string, int> quoteTracker = new Dictionary<string, int>();
    IList<string> finalList = new List<string>();

    public void Run()
    {
        int numOfToys = 6;
        int topToys = 3;
        string[] toys = { "elmo", "elsa", "legos", "drone", "tablet", "warcraft" };
        int numQuotes = 6;
        string[] quotes = {
            "Elmo Elmo Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
            "The new dolls are super high quality",
            "Expect the Elsa dolls to be very popular this year, Elsa!",
            "Elsa and are the toys I'll be buying for my kids, Elsa is good",
            "For parents of older kids, look into buying them a drone",
            "Warcraft is slowly rising in popularity ahead of the holiday season"
        };
        string[] result = GetResult(numOfToys, topToys, toys, numQuotes, quotes);
        foreach (string data in result)
        {
            Console.WriteLine(data);
        }

    }

    private string[] GetResult(int numOfToys, int topToys, string[] toys, int numQuotes, string[] quotes)
    {
        HashSet<string> toysToLookOutFor = new HashSet<string>(toys);

        for (int i = 0; i < numQuotes; i++)
        {
            this.AddSearchedWordToList(quotes[i], toysToLookOutFor, i + 1);
        }

        var names = finalList.GroupBy(x => x)
                    .OrderByDescending(x => x.Count())
                    .ThenBy(y => y.Key)
                    .Select(e => new { word = e.Key, count = e.Count() })
                    .Take(topToys).ToList();

        List<string> resultData = new List<string>();

        foreach (var entry in names)
        {
            resultData.Add(entry.word);
            // Console.WriteLine(entry.word + " - " + entry.count);
        }

        CalculateWordOccurrencesInQuotes(resultData.ToArray(), quotes);

        return quoteTracker.Keys.ToArray();
    }

    private void AddSearchedWordToList(string quote, HashSet<string> toysToLookOutFor, int quoteNo)
    {
        string[] cleanWords = RemoveSpecialCharacters(quote).ToLower().Split(" ");
        foreach (string word in cleanWords)
        {
            if (toysToLookOutFor.Contains(word))
            {
                finalList.Add(word);
            }
        }
    }

    private void AddToDictionary(string word)
    {
        if (quoteTracker.ContainsKey(word))
        {
            quoteTracker[word]++;
        }
        else
            quoteTracker.Add(word, 1);
    }

    // Also sort aphabetical if mentioned equal number of times in quotes
    private void CalculateWordOccurrencesInQuotes(string[] words, string[] quotes)
    {

        foreach (string word in words)
        {
            foreach (string quote in quotes)
            {
                if (quote.ToLower().Contains(word))
                {
                    AddToDictionary(word);
                }
            }
        }
    }

    private string RemoveSpecialCharacters(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in str)
        {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

}