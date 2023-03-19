/*
 * Author: Deean
 * Date: 2023-03-19 13:01:55
 * FileName: P2248.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2248 {
    public class Solution {
        public IList<int> Intersection(int[][] nums) {
            int[] number = new int[1001];
            foreach (var item in nums) {
                foreach (var num in item) {
                    number[num]++;
                }
            }
            IList<int> list = new List<int>();
            for (int i = 0; i < 1001; i++) {
                if (number[i] == nums.Length) {
                    list.Add(i);
                }
            }
            return list;
        }
    }

    public static void Test() {
        int[][] nums = new int[3][];
        nums[0] = new[] { 3, 1, 2, 4, 5 };
        nums[1] = new[] { 1, 2, 3, 4 };
        nums[2] = new[] { 5, 6, 3, 4 };
        var s = new Solution();
        var ans = s.Intersection(nums);
        Console.WriteLine(ans);
    }
}