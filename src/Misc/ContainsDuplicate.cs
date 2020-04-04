// https://leetcode.com/problems/contains-duplicate/
// 217. Contains Duplicate

using System;
using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums.Length == 0) return false;
        
        HashSet<int> uniqueNumbers = new HashSet<int>(nums);
        if (uniqueNumbers.Count == nums.Length) return false;
        return true;        
      
    }
}