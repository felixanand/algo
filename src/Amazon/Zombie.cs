//https://leetcode.com/discuss/interview-question/411357/

//Given a 2D grid, each cell is either a zombie 1 or a human 0. Zombies can turn adjacent (up/down/left/right) 
//human beings into zombies every hour. Find out how many hours does it take to infect all humans?

namespace Amazon
{
    using System;
    using System.Collections.Generic;

    public class Zombie
    {
        public void Run()
        {
            Console.WriteLine("Zombie");
            int[][] inputData = new int[4][];
            inputData[0] = new int[] { 0, 1, 1, 0, 1 };
            inputData[1] = new int[] { 0, 1, 0, 1, 0 };
            inputData[2] = new int[] { 0, 0, 0, 0, 1 };
            inputData[3] = new int[] { 0, 1, 0, 0, 0 };
            int minNumberOfMinutes = GetMinMinutes(inputData);
            Console.WriteLine(minNumberOfMinutes);
        }

        // Queue to hold all Zombie Coordinates
        Queue<int[]> q = new Queue<int[]>();
        // Humans
        int humans = 0;
        // Minutes taken to Rotten
        int minutesTaken = 0;

        // Get Minutes taken to Rotten entire orange set
        public int GetMinMinutes(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                        q.Enqueue(new int[] { i, j });
                    else if (grid[i][j] == 0)
                        humans++;
                }
            }

            while (humans > 0)
            {
                var size = q.Count;
                minutesTaken++;

                if (size == 0 && humans > 0)
                    return -1;

                while (size > 0)
                {
                    var curItem = q.Dequeue();
                    size--;
                    var x = curItem[0];
                    var y = curItem[1];
                    ConvertToZombie(grid, x + 1, y); //up
                    ConvertToZombie(grid, x - 1, y); //down
                    ConvertToZombie(grid, x, y - 1); //left
                    ConvertToZombie(grid, x, y + 1); //right
                }
            }
            return minutesTaken;
        }

        public void ConvertToZombie(int[][] grid, int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
                return;

            if (grid[x][y] == 0)
            {
                grid[x][y] = 1;
                humans--;
                q.Enqueue(new int[] { x, y });
            }


        }
    }
}