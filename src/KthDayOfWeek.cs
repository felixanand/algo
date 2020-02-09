// Find the day after k days 
// https://leetcode.com/discuss/interview-question/398047/

using System;
using System.Linq;
using System.Collections.Generic;

public class KthDay
{
    public void Run()
    {
        Console.WriteLine("Kth Day");        
        string day = "Sat";
        int inpDate = 23;
        Console.WriteLine("The Day after {0} days is {1}", inpDate, GetDaysLater(day, inpDate));
    }

    private string GetDaysLater(string day, int inputDate)
    {
        string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        IDictionary<string, int> dateHolder = new Dictionary<string, int>();
        for (int i = 1; i <= days.Length; i++)
        {
            dateHolder.Add(days[i - 1], i);
        }
        return dateHolder.FirstOrDefault(x=>x.Value == ((dateHolder[day] + inputDate) % 7)).Key; 
    }
}
