/*
 * Author: Deean
 * Date: 2023-04-02 19:14:05
 * FileName: P0977.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0977 {
    public class Solution {
        public int[] SortedSquares(int[] nums) {
            List<int> square = new List<int>();
            int left = 0, right = nums.Length - 1;
            while (left <= right) {
                if (Math.Abs(nums[left]) >= Math.Abs(nums[right])) {
                    square.Add(nums[left] * nums[left]);
                    left++;
                } else {
                    square.Add(nums[right] * nums[right]);
                    right--;
                }
            }
            return square.ToArray().Reverse().ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortedSquares(new[]{-4,-1,0,3,10});
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}