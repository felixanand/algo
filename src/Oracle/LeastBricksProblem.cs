// 554. Brick Wall
// https://leetcode.com/problems/brick-wall/

using System;
using System.Collections.Generic;
using System.Linq;

public class LeastBricksProblem
{
    public void Run()
    {
        IList<IList<int>> wall = new List<IList<int>>();
        List<int> data = new List<int>();
        wall.Add(new List<int> { 1, 2, 2, 1 });
        wall.Add(new List<int> { 3, 1, 2 });
        wall.Add(new List<int> { 1, 3, 2 });
        wall.Add(new List<int> { 2, 4 });
        wall.Add(new List<int> { 3, 1, 2 });
        wall.Add(new List<int> { 1, 3, 1, 1 });

        int result = LeastBricks(wall);
        Console.WriteLine(result);

    }

    public int LeastBricks(IList<IList<int>> wall)
    {
        Dictionary<int,int> res = new Dictionary<int, int>();

        foreach (var row in wall)
        {
            var total = 0;

            for (var i = 0; i < row.Count - 1; i++)
            {
                total += row[i];

                res[total] = res.ContainsKey(total) ? res[total] + 1 : 1;
            }
        }

        return wall.Count - (res.Count > 0 ? res.Values.Max() : 0);
    }
}