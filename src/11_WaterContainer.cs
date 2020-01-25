// https://leetcode.com/problems/container-with-most-water/
// Problem Number 11
// Complexity Medium

// Note: The better solution was to apply left right sqeeze algorithm

using System;
using System.Collections.Generic;

public class WaterContainer{
    
    public void Run(){
        Console.WriteLine("Water Container Problem: ");
        int[] inputData = {1,8,6,2,5,4,8,3,7};
        //int[] inputData = {1,1};
        Console.WriteLine("Max Area is {0}", MaxArea(inputData));
    }

     public int MaxArea(int[] height) {
         if (height.Length<0) return -1;
         int maxHeight= Int16.MinValue;
         int possibleArea = 1;        
         for (int i=0; i<= height.Length - 1; i++)
         {
             for (int j = i+1; j <= height.Length -1; j++)
             {
                 possibleArea = Math.Min(height[i],height[j]) * (j-i);
                 maxHeight = possibleArea > maxHeight ? possibleArea : maxHeight;
             }
         }
         return maxHeight;
     }

}
