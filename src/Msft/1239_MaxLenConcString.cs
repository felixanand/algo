// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
// Incorrect solution - Need to fix

namespace MSFT
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxLenConcString
    {
        public void Run()
        {
            Console.WriteLine("Maximum Length of Concatenated String :");
            string[] input = new string[] { "un", "iq", "ue" };
            Console.WriteLine("Max length of possible concatented string: {0}", GetMaxLength(input));
        }

        private int GetMaxLength(IList<string> arr)
        {
            int totalLength = 0;
            if (arr.Count() < 2)
            {
                return (arr.Count() == 1) ? arr[0].Length : 0;
            }
            Dictionary<string, int> dataHolder = new Dictionary<string, int>();
            foreach (string item in arr)
            {
                dataHolder.Add(item, item.Length);
            }
            totalLength = dataHolder.Values.Max();
            dataHolder.Remove(dataHolder.FirstOrDefault(x => x.Value == dataHolder.Values.Max()).Key);
            totalLength += dataHolder.Values.Max();
            return totalLength;
        }
    }
}